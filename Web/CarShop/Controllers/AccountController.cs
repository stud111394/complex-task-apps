using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CarShop.Models;
using CarShop.Models.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Controllers
{
    public class AccountController : Controller
    {
        private AvtozapContext db;
        public AccountController(AvtozapContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult Login()
        {
            LoginViewModel model = new LoginViewModel()
            {
                Categories = db.Category
            };

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                Klient user = db.Klient.FirstOrDefault(u => u.Telefon.ToString() == model.Phone);
                if (user != null)
                {
                    await Authenticate(model.Phone.ToString()); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Register()
        {
            RegisterViewModel model = new RegisterViewModel()
            {
                Categories = db.Category
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                Klient user = db.Klient.FirstOrDefault(u => u.Telefon.ToString() == model.Phone);
                if (user == null)
                {
                    // добавляем пользователя в бд
                    db.Klient.Add(new Klient { Telefon = Decimal.Parse(model.Phone), 
                        F = model.LastName, 
                        I = model.Name, 
                        O = model.ThirdName});
                    await db.SaveChangesAsync();

                    await Authenticate(model.Phone.ToString()); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }

        private async Task Authenticate(string userName)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}
