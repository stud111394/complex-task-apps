using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CarShop.Models
{
    public partial class CarZap
    {
        public int IdCarZap { get; set; }
        public int IdCar { get; set; }
        public string Nazvanie { get; set; }
        public int IdPostav { get; set; }
        public decimal Cena { get; set; }
        public string ImgLink { get; set; }
        public int? IdCategory { get; set; }
    }
}
