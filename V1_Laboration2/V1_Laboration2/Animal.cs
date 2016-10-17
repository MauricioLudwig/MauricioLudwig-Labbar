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
        public string Species { get; set; }

        public virtual string ShortDescription()
        {
            return String.Format("The {0} is {1} years old and weighs approx. {2} kg.", 
                Species,
                Age,
                Weight);
        }

        public virtual string Habitat()
        {
            return String.Format("The {0} resides on planet Earth",
                Species);
        }
    }
}