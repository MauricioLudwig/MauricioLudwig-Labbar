using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2_Laboration3
{
    class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Event> MyBookings { get; set; }

        public Person()
        {
            MyBookings = new List<Event>();
        }
    }
}
