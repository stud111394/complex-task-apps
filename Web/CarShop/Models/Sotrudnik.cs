using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CarShop.Models
{
    public partial class Sotrudnik
    {
        public int IdSotr { get; set; }
        public string PersInf { get; set; }
        public decimal Telefon { get; set; }
        public int IdDolzhnost { get; set; }
        public string Parol { get; set; }
        public int Login { get; set; }
    }
}
