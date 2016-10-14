using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V1_Laboration2
{
    public class Bear : Mammal
    {
        public string Home { get; set; }
        public string Size { get; set; }

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