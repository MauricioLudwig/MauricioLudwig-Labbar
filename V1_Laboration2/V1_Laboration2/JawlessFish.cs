using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V1_Laboration2
{
    public class JawlessFish : Fish
    {

        public string Something { get; set; }
        public bool SomethingElse { get; set; }

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