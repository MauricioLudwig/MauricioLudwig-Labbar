using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V2_Laboration3
{
    public class Concert : Event
    {

        public string Location { get; set; }
        public bool Outdoors { get; set; }

        public override string EventDescription()
        {
            return String.Format("{0}" + Environment.NewLine +
                "{1}" + Environment.NewLine +
                "Location: {2}",
                base.EventDescription(),
                Outdoors == true ? "Bring a jacket! This venus is outdoors." : "Venue is indoors. Enjoy the fumes of a hundred perspiring attendees!",
                Location);
        }
    }
}