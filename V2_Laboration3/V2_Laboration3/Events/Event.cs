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
            string year, month, day;
            string[] splitDate = Date.Split('/');
            year = splitDate[0];
            month = splitDate[1];
            day = splitDate[2];

            return String.Format("Year: {0} Day: {1}/{2}", year, day, month);
        }

        public virtual string BookingInfo()
        {
            return "";
        } 
    }
}