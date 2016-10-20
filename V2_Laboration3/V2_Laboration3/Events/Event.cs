using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V2_Laboration3
{
    public abstract class Event
    {

        public string Name { get; set; }
        public string EventID { get; set; }
        public int Fee { get; set; }
        public DateTime Date { get; set; }

        public virtual string EventDescription()
        {
            return String.Format("{0}" + Environment.NewLine +
                "Date: {1}" + Environment.NewLine +
                "Fee: {2}",
                Name,
                PrintDate(),
                Fee);
        }

        public string PrintDate()
        {
            return String.Format("{0:dd/MM/yyyy}", Date);
        }
    }
}