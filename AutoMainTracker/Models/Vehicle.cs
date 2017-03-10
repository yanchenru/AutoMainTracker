using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMainTracker.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Odometer { get; set; }
    }

    public class Gas : Vehicle { }

    public class Electric : Vehicle { }

    public class Diesel : Vehicle { }
}