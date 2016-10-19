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
            Person person = new Person();

            bool DisplayMainMenu = true;

            while (DisplayMainMenu)
            {

                Console.Clear();
                Menus.MainMenu();

                int choice = ValidateInput.ValidateInteger(1, 6);

                switch (choice)
                {
                    case 1: // Concert
                        eventManager.ShowAvailableBookings(eventManager.Concerts);
                        break;
                    case 2: // Movie
                        eventManager.ShowAvailableBookings(eventManager.Movies);
                        break;
                    case 3: // Theater
                        eventManager.ShowAvailableBookings(eventManager.Theaters);
                        break;
                    case 4: // Comic Con
                        eventManager.ShowAvailableBookings(eventManager.ComicCons);
                        break;
                    case 5: // Show Bookings
                        person.ShowBookings();
                        break;
                    case 6: // Exit Program
                        DisplayMainMenu = false;
                        break;
                    default:
                        Console.WriteLine("This message should never display on the console window.");
                        break;
                }
            }


        }
    } // Class
} // Namespace
