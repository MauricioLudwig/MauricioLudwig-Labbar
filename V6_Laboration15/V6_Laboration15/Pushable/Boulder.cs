using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V6_Laboration15
{
    public class Boulder : IPushable
    {
        public void Push()
        {
            Console.WriteLine("Push.");
        }
    }
}