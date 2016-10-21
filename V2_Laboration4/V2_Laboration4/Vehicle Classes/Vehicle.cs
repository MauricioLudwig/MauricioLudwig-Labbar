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
        public string Category { get; set; }

        public virtual string VehicleDescription()
        {
            return String.Format("{0,-15} {1,-15} {2,-10} {3,-10} {4}",
                Manufacturer, Model, Year, Color, Price);
        }

        public static void VehicleLabel()
        {
            Console.WriteLine("{0,-15} {1,-15} {2,-10} {3,-10} {4}" + Environment.NewLine,
                "Manufacturer", "Model", "Year", "Color", "Price");
        }

    }
}