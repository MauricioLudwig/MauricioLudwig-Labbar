using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V6_Laboration14
{
    abstract class Person
    {
        private int age;
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    value = "Unknown";
                name = value;
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 1)
                    value = 1;
                age = value;
            }
        }

        public virtual string AuthorDescription()
        {
            return String.Format("Written by: {0}, {1}", Name, Age);
        }
    }
}
