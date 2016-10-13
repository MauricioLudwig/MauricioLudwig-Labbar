using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1_Laboration1
{
    class Menus
    {
        public static void Menu()
        {
            Console.WriteLine("-------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. Add new dog");
            Console.WriteLine("2. Remove dog");
            Console.WriteLine("3. Show info");
            Console.WriteLine("4. Exit");
            Console.ResetColor();
            Console.WriteLine("-------------------------------");
        }
    }
}
