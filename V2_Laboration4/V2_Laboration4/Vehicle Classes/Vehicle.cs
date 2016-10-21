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
        public int Price { get; set; }

        public virtual string VehicleDescription()
        {
            return String.Format("Manufacturer: {0,-15} Model: {1,-15} Year: {2,-10} Color: {3,-10} Price: {4}",
                Manufacturer, Model, Year, Color, Price);
        }

    }
}