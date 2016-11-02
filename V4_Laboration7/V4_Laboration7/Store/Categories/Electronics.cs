using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V4_Laboration7
{
    public class Electronics : Product
    {

        public int Weight { get; set; }

        public override string ProductParameterLabels()
        {
            return String.Format("{0,-20}{1}",
                base.ProductParameterLabels(),
                "Weight (in kg)");
        }

        public override string ProductParameterValues()
        {
            return String.Format("{0,-20}{1}",
                base.ProductParameterValues(),
                Weight);
        }

        public override string UniquePropertyString()
        {
            return " kg (Weight)";
        }
    }
}