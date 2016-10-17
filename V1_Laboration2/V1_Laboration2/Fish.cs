using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V1_Laboration2
{
    public abstract class Fish : Animal
    {

        public bool Carnivorous { get; set; }
        public double OceanDepth { get; set; }
    }
}