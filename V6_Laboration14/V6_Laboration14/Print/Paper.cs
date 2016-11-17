using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V6_Laboration14
{
    class Paper : Publication
    {

        public int Issue { get; set; } 
        public override string PrintDescription()
        {
            return String.Format("{0}\nIssue: {1}",
                base.PrintDescription(),
                Issue);
        }
    }
}
