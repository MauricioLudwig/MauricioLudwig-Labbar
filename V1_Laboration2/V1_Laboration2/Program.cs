using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1_Laboration2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Instantiate Runtime and invoke its Start method
            var runtime = new Runtime();
            runtime.Start();

            Console.WriteLine("You have reached the end of the program.");
            Console.ReadKey(true);
        }
    }
}
