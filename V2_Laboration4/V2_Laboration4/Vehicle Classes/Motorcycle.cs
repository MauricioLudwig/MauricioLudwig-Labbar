using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V2_Laboration4
{
    public class Motorcycle : Vehicle
    {

        public string Type { get; set; }
        public int Year { get; set; }

        public override string VehicleInfo()
        {
            return String.Format("{0}" + Environment.NewLine + "{1,-5}This {2} motorcycle is a {3}.",
                base.VehicleInfo(),
                "",
                Year, 
                Type);
        }

    }
}