using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Models.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<CarZap> CarZaps;
        public IEnumerable<Category> Categories;
    }
}
