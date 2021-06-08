using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Models;
using CarShop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Controllers
{
    public class ZapController : Controller
    {
        private AvtozapContext _db;
        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CarZap carZap = _db.CarZap.FirstOrDefault(m => m.IdCarZap == id);

            ZapViewModel zvc = new ZapViewModel()
            {
                CarZapItem = carZap,
                CarZapItemCategory = _db.Category.FirstOrDefault(m => m.Id == carZap.IdCategory),
                Categories = _db.Category
            };

            return View(zvc);
        }

        public ZapController(AvtozapContext db)
        {
            _db = db;
        }
    }
}
