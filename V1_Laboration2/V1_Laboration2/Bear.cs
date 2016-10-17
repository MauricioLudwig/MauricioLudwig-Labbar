using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V1_Laboration2
{
    public class Bear : Mammal
    {

        public string Color { get; set; }
        public double BiteForce { get; set; }

        public override string ShortDescription()
        {
            return String.Format("{0} This {1} bear has a biteforce of {2} BFQ and packs a set of {3} teeth. It feeds mainly on {4}.",
                base.ShortDescription(),
                Color,
                BiteForce, 
                NumberOfTeeth, 
                Diet);
        }

        public override string Habitat()
        {
            return String.Format("{0} and hybernates regularly during winter.",
                base.Habitat());
        }
    }
}