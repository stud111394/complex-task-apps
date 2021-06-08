using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CarShop.Models
{
    public partial class Klient
    {
        public int IdKlient { get; set; }
        public string F { get; set; }
        public string I { get; set; }
        public string O { get; set; }
        public decimal Telefon { get; set; }
    }
}
