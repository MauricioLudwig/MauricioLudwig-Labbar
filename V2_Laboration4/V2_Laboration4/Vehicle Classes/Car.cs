using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V2_Laboration4
{
    public class Car : Vehicle
    {

        public bool IsSedan { get; set; }
        public int HorsePower { get; set; }

        public override string VehicleInfo()
        {
            return String.Format("{0}" + Environment.NewLine + "{1,-5}This car is {2} and sports {3} horsepowers.",
                base.VehicleInfo(),
                "",
                IsSedan == true ? "a sedan" : "not a sedan",
                HorsePower);
        }

    }
}