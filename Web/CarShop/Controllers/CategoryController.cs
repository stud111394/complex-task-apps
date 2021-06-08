using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Models;
using CarShop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Controllers
{
    public class CategoryController : Controller
    {
        private AvtozapContext _db;
        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category item = _db.Category.FirstOrDefault(m => m.Id == id);

            CategoryViewModel cvm = new CategoryViewModel()
            {
                ItemCategory = item,
                CarZaps = _db.CarZap.Where(m => m.IdCategory == item.Id),
                Categories = _db.Category
            };

            return View(cvm);
        }

        public CategoryController(AvtozapContext db)
        {
            _db = db;
        }
    }
}
