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
        public List<Event> AllAvailableEvents { get; set; }
        public int Index { get; set; }

        public EventManager()
        {

            // Create 3 objects of Concert upon initializing EventManager
            #region Concert Listings
            Concerts = new List<Concert>
            {
                new Concert() { Name = "Oasis",              EventID = "Concert", Fee = 150, Date = new DateTime(2016, 12, 31), Location = "Stockholm", Outdoors = true  },
                new Concert() { Name = "Elton John",         EventID = "Concert", Fee = 200, Date = new DateTime(2017, 10, 18), Location = "Paris",     Outdoors = false },
                new Concert() { Name = "The Stone Roses",    EventID = "Concert", Fee = 300, Date = new DateTime(2020, 01, 01), Location = "Barcelona", Outdoors = true  }
            };
            #endregion

            // Create 3 objects of Theater upon initializing EventManager
            #region Theater Listings
            Theaters = new List<Theater>()
            {
                new Theater() { Name = "The Book of Mormon",       EventID = "Theater", Fee = 200, Date = new DateTime(2018, 12, 01), Genre = "Comedy",  NumOfActs = 10 },
                new Theater() { Name = "Hamlet",                   EventID = "Theater", Fee = 300, Date = new DateTime(2016, 12, 24), Genre = "Tragedy", NumOfActs = 11 },
                new Theater() { Name = "A Streetcar Named Desire", EventID = "Theater", Fee = 400, Date = new DateTime(2017, 08, 08), Genre = "Drama",   NumOfActs = 12 }
            };
            #endregion

            // Create 3 objects of Movie upon initializing EventManager
            #region Movie Listings
            Movies = new List<Movie>()
            {
                new Movie() { Name = "Arrival",                      EventID = "Movie", Fee = 120, Date = new DateTime(2016, 12, 02), is3D = true,  MetaScore = 80 },
                new Movie() { Name = "Rogue One: A Star Wars Story", EventID = "Movie", Fee = 150, Date = new DateTime(2016, 12, 14), is3D = true,  MetaScore = 50 },
                new Movie() { Name = "Passengers",                   EventID = "Movie", Fee = 180, Date = new DateTime(2016, 12, 21), is3D = false, MetaScore = 77 }
            };
            #endregion

            AllAvailableEvents = new List<Event>();
            AllAvailableEvents.AddRange(Concerts);
            AllAvailableEvents.AddRange(Theaters);
            AllAvailableEvents.AddRange(Movies);
        }

        public void AvailableConcerts(Concert concert)
        {
            Console.WriteLine("{0}. " + concert.EventDescription(), Index++);
            Console.WriteLine();
        }

        public void AvailableTheaters(Theater theater)
        {
            Console.WriteLine("{0}. " + theater.EventDescription(), Index++);
            Console.WriteLine();
        }

        public void AvailableMovies(Movie movie)
        {
            Console.WriteLine("{0}. " + movie.EventDescription(), Index++);
            Console.WriteLine();
        }
        public void SearchEvent()
        {
            string input;
            bool stringInput;
            int intInput;

            do
            {
                Menus.HeaderAndSubHeader("Search by Name or Year", "Type \'exit\' to return to main menu");
                TextColor.Yellow("Input: ");
                input = Console.ReadLine();

                stringInput = int.TryParse(input, out intInput);

                if (stringInput)
                {
                    Event[] findEvent = AllAvailableEvents
                        .Where(mEvent => mEvent.Date.Year.Equals(intInput))
                        .ToArray();

                    if (findEvent.Length < 1 && input.ToLower() != "exit")
                        TextColor.Red("No match.");
                    else
                    {
                        foreach (var mEvent in findEvent)
                        {
                            TextColor.Blue(Environment.NewLine + "Located in: " + mEvent.EventID + Environment.NewLine);
                            Console.WriteLine(mEvent.EventDescription());
                        }
                    }

                }
                else
                {
                    Event[] findEvent = AllAvailableEvents
                        .Where(mEvent => mEvent.Name.Contains(input))
                        .ToArray();

                    if (findEvent.Length < 1 && input.ToLower() != "exit")
                        TextColor.Red("No match.");
                    else
                    {
                        foreach (var mEvent in findEvent)
                        {
                            TextColor.Blue(Environment.NewLine + "Located in: " + mEvent.EventID + Environment.NewLine);
                            Console.WriteLine(mEvent.EventDescription());
                        }
                    }
                }

                Console.WriteLine(Environment.NewLine + "------------------------");
                Console.WriteLine("Press enter to continue.");
                Console.ReadKey();
                Console.Clear();

            } while (input.ToLower() != "exit");
        }

    }
}
