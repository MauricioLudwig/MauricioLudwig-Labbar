using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V6_Laboration13.Manager;
using V6_Laboration13.UI;

namespace V6_Laboration13
{
    class Runtime
    {

        SuperheroManager SuperheroMgr { get; set; }

        public void Start()
        {

            bool loop = true;

            SuperheroMgr = new SuperheroManager();
            SuperheroMgr.InvalidInput += (message) =>
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input! " + message);
                Console.ResetColor();
            };

            do
            {

                Console.Clear();
                SuperheroMgr.PrintSuperheroes();
                Menus.Start();

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        SuperheroMgr.AddSuperhero();
                        break;
                    case ConsoleKey.D2:
                        FilterOptions();
                        break;
                    case ConsoleKey.D3:
                        loop = false;
                        Console.WriteLine(Environment.NewLine + "Bye!");
                        break;
                }

            } while (loop);
        }

        private void FilterOptions()
        {

            bool loop = true;

            do
            {

                Console.Clear();
                Menus.Filter();
                Console.WriteLine();

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        Console.Write("Number: ");
                        int number = int.Parse(Console.ReadLine());
                        SuperheroMgr.FilterBy(hero => hero.Sidekicks >= number);
                        break;
                    case ConsoleKey.D2:
                        Console.Write("Letter: ");
                        string letter = Console.ReadLine();
                        SuperheroMgr.FilterBy(hero => hero.Name.StartsWith(letter));
                        break;
                    case ConsoleKey.D3:
                        loop = false;
                        break;
                }

                Console.ReadKey();

            } while (loop);
        }

    }
}
