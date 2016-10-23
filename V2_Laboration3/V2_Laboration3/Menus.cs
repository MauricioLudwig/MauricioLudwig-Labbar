using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2_Laboration3
{
    class Menus
    {

        public static void HeaderAndSubHeader(string header, string subHeader)
        {
            Console.WriteLine();
            TextColor.Green(header + Environment.NewLine);
            for (int i = 0; i <= header.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            TextColor.White(subHeader + Environment.NewLine + Environment.NewLine);
        }

        public static void MainMenu()
        {
            Console.WriteLine("1. Concert");
            Console.WriteLine("2. Theater");
            Console.WriteLine("3. Movie");
            Console.WriteLine();
            Console.WriteLine("4. Search for Event");
            Console.WriteLine("5. Show Bookings");
            Console.WriteLine("6. Exit Program");
        }

    }
}
