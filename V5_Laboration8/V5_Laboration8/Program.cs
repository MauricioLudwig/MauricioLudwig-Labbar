using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V5_Laboration8
{

    // Vecka 5, Laboration 8
    class Program
    {
        static void Main(string[] args)
        {
            Runtime runtime = new Runtime();
            int input;

            do
            {
                Console.Clear();
                Console.WriteLine("1. G - Assignment");
                Console.WriteLine("2. VG - Assignment");
                Console.WriteLine("3. Exit Program");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                    runtime.Assignment1();
                else if (input == 2)
                    runtime.Assignment2();

            } while (input != 3);

            Console.Clear();
            Console.WriteLine("You have reached the end of the program.");
            Console.ReadKey();
        }
    }
}
