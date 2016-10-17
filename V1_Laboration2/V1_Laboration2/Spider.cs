using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V1_Laboration2
{
    public class Spider : Arthropod
    {

        public bool BitPeterParker { get; set; }
        public int NumberOfEyes { get; set; }

        public override string ShortDescription()
        {
            if (BitPeterParker == false)
                return String.Format("{0} This {1} spider has {2} eyes, {3} legs and is not responsible for Spiderman.",
                    base.ShortDescription(),
                    Color,
                    NumberOfEyes,
                    NumberOfLegs);
            else
                return String.Format("{0} This {1} spider has {2} eyes, {3} legs and is responsible for Spiderman.",
                    base.ShortDescription(),
                    Color,
                    NumberOfEyes,
                    NumberOfLegs);
        }

        public override string Habitat()
        {
            return String.Format("{0} and specifically in warmer vegetation.",
                base.Habitat());
        }

    }
}