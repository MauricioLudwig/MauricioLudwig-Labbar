using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V4_Laboration7
{
    public class ArtificialOrgan : Product
    {

        public int Longevity { get; set; }

        public override string ProductParameterLabels()
        {
            return String.Format("{0,-20}{1}",
                base.ProductParameterLabels(),
                "Longevity (in years)");
        }

        public override string ProductParameterValues()
        {
            return String.Format("{0,-20}{1}",
                base.ProductParameterValues(),
                Longevity);
        }
    }
}