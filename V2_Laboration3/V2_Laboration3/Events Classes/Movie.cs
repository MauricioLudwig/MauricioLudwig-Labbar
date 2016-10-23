using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V2_Laboration3
{
    public class Movie : Event
    {

        public bool is3D { get; set; }
        public int MetaScore { get; set; }

        public override string EventDescription()
        {
            return String.Format("{0}" + Environment.NewLine +
                "This movie is {1}" + Environment.NewLine +
                "MetaScore: {2}",
                base.EventDescription(),
                is3D == true ? "in 3D" : "not in 3D",
                MetaScore);
        }
    }
}