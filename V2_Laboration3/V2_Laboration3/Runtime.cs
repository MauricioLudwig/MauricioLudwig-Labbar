using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2_Laboration3
{
    class Runtime
    {

        public void Start()
        {

            EventManager eventManager = new EventManager();
            bool DisplayMainMenu = true;

            while (DisplayMainMenu)
            {

                Console.Clear();
                Menus.MainMenu();

                Console.Write(Environment.NewLine + "Choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    // Concert
                    case 1:
                        break;
                    // Movie
                    case 2:
                        break;
                    // Theater
                    case 3:
                        break;
                    // Your Bookings
                    case 4:
                        break;
                    // Exit Program
                    case 5:
                        DisplayMainMenu = false;
                        break;
                    default:
                        Console.WriteLine("This message should not display on the console window.");
                        break;
                }
            }

        }
    }
}
