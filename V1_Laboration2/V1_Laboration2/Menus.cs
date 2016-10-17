using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1_Laboration2
{
    class Menus
    {

        public static void MainMenu()
        {
            Console.WriteLine("1. Add Animal");
            Console.WriteLine("2. Remove Animal");
            Console.WriteLine("3. Show Animals");
            Console.WriteLine("4. Exit Program" + Environment.NewLine);
        }

        public static void AddMenu()
        {
            Console.WriteLine("1. Add Spider");
            Console.WriteLine("2. Add Bear");
            Console.WriteLine("3. Add Shark");
            Console.WriteLine("4. Go Back" + Environment.NewLine);
        }

        public static void RemoveMenu()
        {
            Console.WriteLine("1. Remove Spider");
            Console.WriteLine("2. Remove Bear");
            Console.WriteLine("3. Remove Shark");
            Console.WriteLine("4. Go Back" + Environment.NewLine);
        }

        public static void ShowMenu()
        {
            Console.WriteLine("1. Show Spiders");
            Console.WriteLine("2. Show Bears");
            Console.WriteLine("3. Show Sharks");
            Console.WriteLine("4. Show All");
            Console.WriteLine("5. Go Back" + Environment.NewLine);
        }

    }
}
