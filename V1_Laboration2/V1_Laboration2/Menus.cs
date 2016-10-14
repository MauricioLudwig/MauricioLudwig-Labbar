using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1_Laboration2
{
    class Menus
    {

        public void OptionsMenu(string category)
        {
            TextColors.Green(category);
            Console.WriteLine("1. Add Animal");
            Console.WriteLine("2. Remove Animal");
            Console.WriteLine("3. Show Animals");
            Console.WriteLine("4. Return");
        }

        public static void MainMenu()
        {
            Console.WriteLine("1. Arthropod");
            Console.WriteLine("2. Fish");
            Console.WriteLine("3. Mammal");
            Console.WriteLine("4. Exit Program");
        }

    }
}
