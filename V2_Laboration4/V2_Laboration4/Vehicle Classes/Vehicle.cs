using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V2_Laboration4
{
    public abstract class Vehicle
    {

        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string StockCategory { get; set; }
        public int StockIndex { get; set; }
        public int Price { get; set; }

        public virtual string VehicleInfo()
        {
            return String.Format("{0,-5}{1,-15} {2,-15} {3,-10} {4,-10}",
                StockID(), Manufacturer, Model, Color, Price);
        }

        public static string VehicleLabel()
        {
            return String.Format("{0,-5}{1,-15} {2,-15} {3,-10} {4,-10}",
                "ID", "Manufacturer", "Model", "Color", "Price");
        }

        public string StockID()
        {
            return StockCategory + StockIndex.ToString();
        }

        public int AdjustedPrice()
        {
            return Price / 3 * 2;
        }

    }
}