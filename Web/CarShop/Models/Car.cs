using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CarShop.Models
{
    public partial class Car
    {
        public int IdCar { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int GodVypuska { get; set; }
    }
}
