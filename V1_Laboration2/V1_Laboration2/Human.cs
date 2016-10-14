using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V1_Laboration2
{
    public class Human : Mammal
    {

        public string Ethnicity { get; set; }
        public double Height { get; set; }

        public override void MannerOfCommunication()
        {
            base.MannerOfCommunication();
        }

        public override void MannerOfMovement()
        {
            base.MannerOfMovement();
        }

    }
}