using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1_Laboration1
{
    class Program
    {
        static void Main(string[] args)
        {

            var runtime = new Runtime();
            runtime.Start();

            Console.WriteLine("You have reached the end of the program.");
            Console.ReadKey();
        }
    }
}
