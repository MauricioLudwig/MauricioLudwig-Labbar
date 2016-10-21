using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V2_Laboration4
{
    public class Car : Vehicle
    {

        public bool IsSedan { get; set; }

        public override string VehicleDescription()
        {
            return base.VehicleDescription();
        }
    }
}