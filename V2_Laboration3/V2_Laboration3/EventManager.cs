using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2_Laboration3
{
    class EventManager
    {

        public List<Concert> Concerts { get; set; } 
        public List<Theater> Theaters { get; set; }
        public List<Movie> Movies { get; set; }
        public List<ComicCon> ComicCons { get; set; }

        public EventManager()
        {

            #region Concert Listings
            Concerts = new List<Concert>
            {
                new Concert() { Name = "Oasis",              Fee = 150, Date = "2016/12/31", Location = "Stockholm", Outdoors = true  },
                new Concert() { Name = "Elton John",         Fee = 200, Date = "2017/10/18", Location = "Paris",     Outdoors = false },
                new Concert() { Name = "The Stone Roses",    Fee = 300, Date = "2020/01/01", Location = "Barcelona", Outdoors = true  },
                new Concert() { Name = "The Rolling Stones", Fee = 400, Date = "2017/07/06", Location = "New York",  Outdoors = false }
            };
            #endregion

            #region Theater Listings
            Theaters = new List<Theater>()
            {
                new Theater() { Name = "The Book of Mormon",       Fee = 200, Date = "2018/12/01", Genre = "Comedy",  NumOfActs = 10 },
                new Theater() { Name = "Hamlet",                   Fee = 300, Date = "2016/12/24", Genre = "Tragedy", NumOfActs = 11 },
                new Theater() { Name = "Macbeth",                  Fee = 400, Date = "2017/08/08", Genre = "Tragedy", NumOfActs = 12 },
                new Theater() { Name = "A Streetcar Named Desire", Fee = 500, Date = "2017/04/04", Genre = "Drama",   NumOfActs = 13 }
            };
            #endregion

            #region Movie Listings
            Movies = new List<Movie>()
            {
                new Movie() { Name = "Arrival",                      Fee = 120, Date = "2016/12/02", is3D = true,  MetaScore = 80 },
                new Movie() { Name = "Rogue One: A Star Wars Story", Fee = 150, Date = "2016/12/14", is3D = true,  MetaScore = 50 },
                new Movie() { Name = "Passengers",                   Fee = 180, Date = "2016/12/21", is3D = false, MetaScore = 77 },
                new Movie() { Name = "Assasin's Creed",              Fee = 200, Date = "2017/01/13", is3D = true,  MetaScore = 65 },
                new Movie() { Name = "Batman v Justice League",      Fee = 350, Date = "2020/01/01", is3D = true,  MetaScore = 50 }
            };
            #endregion

        }

        public void ShowAvailableBookings(IEnumerable<dynamic> availableBookings)
        {
            Console.Clear();
            int index = 1;
            int choice;

            try
            {
                foreach (var availableBooking in availableBookings)
                {
                    Console.WriteLine("{0}. {1}", index++, availableBooking.Name);
                }
                Console.WriteLine(Environment.NewLine + "{0}. Return", index);

                choice = ValidateInput.ValidateInteger(1, index);

                if (availableBookings.GetType() == typeof(Movie))
                    Console.WriteLine("This is cinema!");
                Console.ReadKey();

                if (choice != index)
                    ConfirmReservation(choice);
            }
            catch
            {
                Console.Clear();
                TextColor.Red("No available bookings at this time. Sorry!");
                Console.WriteLine(Environment.NewLine + Environment.NewLine +
                    "Press enter to return to main menu.");
                Console.ReadKey();
            }
        }

        public void ConfirmReservation(int choice)
        {
        }

    }
}
