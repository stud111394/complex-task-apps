using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CarShop.Models.ViewModels
{
    public class LoginViewModel
    {
        public IEnumerable<Category> Categories;

        [Required(ErrorMessage = "Не указан телефоны")]
        public string Phone { get; set; }
    }
}
