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

            bool displayMainMenu = true;

            while (displayMainMenu)
            {

                // First Menu
                Console.Clear();
                Menus.HeaderAndSubHeader
                    ("Booking Manager", "Welcome! Make your selection below.");
                Menus.MainMenu();

                int mainMenuChoice = ValidateInput.ValidateInteger(1, 5);

                // Second Menu
                Console.Clear();
                Menus.HeaderAndSubHeader("Available Bookings", "Select, confirm, done!");

                eventManager.Index = 1;
                int reservationChoice;

                switch (mainMenuChoice)
                {
                    case 1:
                        // Concert listings
                        eventManager.Concerts.ForEach(eventManager.AvailableConcerts);
                        Console.WriteLine("{0}. Return.", eventManager.Index);
                        
                        // Specific concert choice
                        reservationChoice = ValidateInput.ValidateInteger(1, eventManager.Index);

                        // Confirm or deny booking
                        if (reservationChoice != eventManager.Index)
                        {
                            --reservationChoice;
                            if (ConfirmBooking(eventManager.Concerts[reservationChoice].Name))
                                person.MyBookings.Add(eventManager.Concerts[reservationChoice]);                                
                        }
                        break;
                    case 2:
                        // Theater listings
                        eventManager.Theaters.ForEach(eventManager.AvailableTheaters);
                        Console.WriteLine("{0}. Return.", eventManager.Index);

                        // Specific theater choice
                        reservationChoice = ValidateInput.ValidateInteger(1, eventManager.Index);

                        // Confirm or deny booking
                        if (reservationChoice != eventManager.Index)
                        {
                            --reservationChoice;
                            if (ConfirmBooking(eventManager.Theaters[reservationChoice].Name))
                                person.MyBookings.Add(eventManager.Theaters[reservationChoice]);
                        }
                        break;
                    case 3:
                        // Movie listings
                        eventManager.Movies.ForEach(eventManager.AvailableMovies);
                        Console.WriteLine("{0}. Return.", eventManager.Index);

                        // Specific movie choice
                        reservationChoice = ValidateInput.ValidateInteger(1, eventManager.Index);

                        // Confirm or deny booking
                        if (reservationChoice != eventManager.Index)
                        {
                            --reservationChoice;
                            if (ConfirmBooking(eventManager.Movies[reservationChoice].Name))
                                person.MyBookings.Add(eventManager.Movies[reservationChoice]);
                        }
                        break;
                    case 4:
                        // Show Bookings
                        Console.Clear();
                        Menus.HeaderAndSubHeader("Booking Manager", "Scroll through your list of bookings.");
                        foreach (var booking in person.MyBookings)
                        {
                            Console.Write(booking.EventDescription());
                            Console.WriteLine(Environment.NewLine);
                        }
                        Console.ReadKey();
                        break;
                    case 5:
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
