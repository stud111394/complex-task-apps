using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Models.ViewModels
{
    public class CategoryViewModel
    {
        public IEnumerable<CarZap> CarZaps;
        public Category ItemCategory;
        public IEnumerable<Category> Categories;
    }
}
