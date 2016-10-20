using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V2_Laboration4
{
    public abstract class Vehicle
    {

        public string Color { get; set; }
        public string Brand { get; set; }
        public string Modell { get; set; } 
        public int Year { get; set; }
        public bool Used { get; set; }
        public float Price { get; set; }

        public virtual string PrintVehicle()
        {
            return "";
        }

        public virtual float UsedCarRevisedPrice()
        {
            return 2F;
        }
    }
}