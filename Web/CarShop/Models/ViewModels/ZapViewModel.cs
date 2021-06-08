using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Models.ViewModels
{
    public class ZapViewModel
    {
        public CarZap CarZapItem;
        public Category CarZapItemCategory;
        public IEnumerable<Category> Categories;
    }
}
