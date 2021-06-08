using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CarShop.Models
{
    public partial class Postavshiki
    {
        public int IdPostav { get; set; }
        public string NameOrgan { get; set; }
        public string Adress { get; set; }
        public decimal Telefon { get; set; }
    }
}
