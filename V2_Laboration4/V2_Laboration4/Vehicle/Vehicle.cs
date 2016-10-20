using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V2_Laboration4
{
    public abstract class Vehicle
    {

        public string Color { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool Used { get; set; }
        public float Price { get; set; }

        public virtual string VehicleInfo()
        {
            return "";
        }

        public virtual float VehicleListing()
        {
            return 0F;
        }
    }
}