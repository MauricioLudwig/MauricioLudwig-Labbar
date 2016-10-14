using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V1_Laboration2
{
    public class Shark : Fish
    {

        public bool Something { get; set; }
        public string SomethingElse { get; set; }

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