using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V6_Laboration14
{
    class Magazine : Publication
    {
        public string Color { get; set; }

        public override string PrintDescription()
        {
            return String.Format("{0}\nColor: {1}",
                base.PrintDescription(),
                Color);
        }
    }
}
