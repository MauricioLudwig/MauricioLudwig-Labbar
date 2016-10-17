using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V1_Laboration2
{
    public class Shark : Fish
    {

        public double Length { get; set; }
        public string ScientificName { get; set; }

        public override string ShortDescription()
        {
            if (Carnivorous == false)
                return String.Format("{0} This shark is not carnivorous. It has a length of {1} meters and is able to go as deep as {2} meters below the surface. Its scientific name is {3}.",
                    base.ShortDescription(),
                    Length,
                    OceanDepth,
                    ScientificName);
            else
                return String.Format("{0} This shark is carnivorous. It has a length of {1} meters and is able to go as deep as {2} meters below the surface. Its scientific name is {3}.",
                    base.ShortDescription(),
                    Length,
                    OceanDepth,
                    ScientificName);
        }

        public override string Habitat()
        {
            return String.Format("{0} and is dependent on salt-water.",
                base.Habitat());
        }

    }
}