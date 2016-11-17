using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V6_Laboration13.UI
{
    class Menus
    {

        public static void Start()
        {
            Console.WriteLine(Environment.NewLine + "--------------------------------" + Environment.NewLine);
            Console.WriteLine("1. Add Superhero");
            Console.WriteLine("2. Filter");
            Console.WriteLine("3. Exit Application");
        }

        public static void Filter()
        {
            Console.WriteLine("1. Filter by number of sidekicks (equal or more than)");
            Console.WriteLine("2. Filter by first letter in the name");
            Console.WriteLine("3. Return");
        }
    }
}
