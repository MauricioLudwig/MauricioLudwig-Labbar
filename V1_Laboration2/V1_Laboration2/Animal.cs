using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V1_Laboration2
{
    public abstract class Animal
    {

        public int Age { get; set; }
        public double Weight { get; set; }
        public bool WarmBlooded { get; set; }


        public virtual void TypeOfMovement()
        {

        }

    }
}