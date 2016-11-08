using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V5_Laboration8
{
    class Lists
    {

        public string[] MyStrings { get; set; }
        public float[] MyFloats { get; set; }

        public Lists()
        {

            MyStrings = new string[]
            {
                "Hello",
                "Damien",
                "Demon",
                "Child",
                "of",
                "Hell"
            };

            MyFloats = new float[]
            {
                1.1F,
                2.2F,
                3.3F,
                4.4F,
                5.5F,
                6.6F
            };

        }
    }
}
