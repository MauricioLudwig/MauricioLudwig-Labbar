using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1_Laboration1
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }

        public string ShowInfo()
        {
            return String.Format("{0,-15} {1,-15} {2}", Name, Age, Breed);
        }
    }
}
