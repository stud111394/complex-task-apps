using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CarShop.Models
{
    public partial class Prodazha
    {
        public int IdProdazhi { get; set; }
        public int IdCarZap { get; set; }
        public int Kolichestvo { get; set; }
        public int IdStatus { get; set; }
        public int IdSotr { get; set; }
        public int IdKlient { get; set; }
        public DateTime DataPokupki { get; set; }
    }
}
