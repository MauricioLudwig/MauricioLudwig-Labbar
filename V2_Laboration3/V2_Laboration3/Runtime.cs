using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2_Laboration3
{
    class Runtime
    {
        EventManager eventManager = new EventManager();
        Person person = new Person();

        public void Start()
        {

            bool displayMainMenu = true;

            while (displayMainMenu)
            {

                // Main Menu
                Console.Clear();
                Menus.HeaderAndSubHeader
                    ("Booking Manager", "Welcome! Make your selection below.");
                Menus.MainMenu();
                int mainMenuChoice = ValidateInput.ValidateInteger(1, 6);

                // Second Menu
                Console.Clear();
                Menus.HeaderAndSubHeader("Available Bookings", "Select, confirm, done!");

                eventManager.Index = 1;
                int eventChoice;

                switch (mainMenuChoice)
                {
                    case 1:
                        // Listing available concerts
                        eventManager.Concerts.ForEach(eventManager.AvailableConcerts);
                        Console.WriteLine("{0}. Return.", eventManager.Index);
                        
                        // Ascertain desired concert event
                        eventChoice = ValidateInput.ValidateInteger(1, eventManager.Index);

                        // Confirm or deny booking
                        if (eventChoice != eventManager.Index)
                        {
                            --eventChoice;
                            if (ConfirmBooking(eventManager.Concerts[eventChoice].Name))
                                person.MyBookings.Add(eventManager.Concerts[eventChoice]);                                
                        }
                        break;
                    case 2:
                        // Listing available theater plays
                        eventManager.Theaters.ForEach(eventManager.AvailableTheaters);
                        Console.WriteLine("{0}. Return.", eventManager.Index);

                        // Ascertain desired theater play
                        eventChoice = ValidateInput.ValidateInteger(1, eventManager.Index);

                        // Confirm or deny booking
                        if (eventChoice != eventManager.Index)
                        {
                            --eventChoice;
                            if (ConfirmBooking(eventManager.Theaters[eventChoice].Name))
                                person.MyBookings.Add(eventManager.Theaters[eventChoice]);
                        }
                        break;
                    case 3:
                        // Listing available movies
                        eventManager.Movies.ForEach(eventManager.AvailableMovies);
                        Console.WriteLine("{0}. Return.", eventManager.Index);

                        // Ascertain desired movie
                        eventChoice = ValidateInput.ValidateInteger(1, eventManager.Index);

                        // Confirm or deny booking
                        if (eventChoice != eventManager.Index)
                        {
                            --eventChoice;
                            if (ConfirmBooking(eventManager.Movies[eventChoice].Name))
                                person.MyBookings.Add(eventManager.Movies[eventChoice]);
                        }
                        break;
                    case 4:
                        // Search for Event
                        Console.Clear();
                        eventManager.SearchEvent();
                        break;
                    case 5:
                        // Show Bookings
                        Console.Clear();
                        Menus.HeaderAndSubHeader("Booking Manager", "Scroll through your list of bookings.");
                        foreach (var booking in person.MyBookings)
                        {
                            TextColor.Blue(booking.EventID + Environment.NewLine);
                            Console.Write(booking.EventDescription());
                            Console.WriteLine(Environment.NewLine);
                        }
                        Console.ReadKey();
                        break;
                    case 6:
                        // Exit Program
                        Console.Clear();
                        displayMainMenu = false;
                        break;
                    default:
                        break;
                }           
            }
        }

        public bool ConfirmBooking(string eventName)
        {
            Console.Clear();
            Console.WriteLine("Would you like to make a reservation for {0}? (yes/no)", eventName);
            Console.Write("Input: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "yes")
            {
                TextColor.Green("Booking confirmed.");
                Console.ReadKey();
                return true;
            }
            else
            {
                TextColor.Red("Booking cancelled.");
                Console.ReadKey();
                return false;
            }
        }

    } // Ending Bracket: Class
} // Ending Bracket: Namespace
