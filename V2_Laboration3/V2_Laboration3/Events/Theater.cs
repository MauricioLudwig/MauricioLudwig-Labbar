using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V2_Laboration3
{
    public class Theater : Event
    {

        public string Genre { get; set; }
        public int NumOfActs { get; set; }

        public override string EventDescription()
        {
            return String.Format("{0}" + Environment.NewLine +
                "This play has {1} acts." + Environment.NewLine +
                "Genre: {2}",
                base.EventDescription(),
                NumOfActs,
                Genre);
        }
    }
}