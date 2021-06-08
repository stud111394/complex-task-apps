using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CarShop.Models.ViewModels;

namespace CarShop.Controllers
{
    public class HomeController : Controller
    {
        private AvtozapContext _db;

        public HomeController(AvtozapContext db)
        {
            _db = db; 
        }

        public IActionResult Index()
        {
            HomeViewModel hvm = new HomeViewModel()
            {
                Categories = _db.Category,
                CarZaps = _db.CarZap
            };
            
            return View(hvm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
