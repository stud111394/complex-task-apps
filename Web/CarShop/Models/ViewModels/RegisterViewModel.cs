using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CarShop.Models.ViewModels
{
    public class RegisterViewModel
    {
        public IEnumerable<Category> Categories;

        [Required(ErrorMessage = "Не указано имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Не указана фамилия")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Не указано отчество")]
        public string ThirdName { get; set; }

        [Required(ErrorMessage = "Не указан телефон")]
        public string Phone { get; set; }
    }
}
