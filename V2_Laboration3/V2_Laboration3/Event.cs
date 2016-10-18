using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V2_Laboration3
{
    public abstract class Event
    {

        public float Fee { get; set; }
        public string Date { get; set; }
        public string Name { get; set; }

        public virtual string DateFormat()
        {
            return "";
        }

        public virtual string BookingInfo()
        {
            return "";
        } 
    }
}