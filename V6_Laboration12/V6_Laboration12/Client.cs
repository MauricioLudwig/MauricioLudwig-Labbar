using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V6_Laboration12.Models;

namespace V6_Laboration12
{
    class Client
    {

        public void Start()
        {

            MovieManager movieMgr = new MovieManager();
            bool loop = true;

            do
            {

                Console.Clear();
                Console.WriteLine(Movie.MovieParameters() + Environment.NewLine);

                foreach (var movie in movieMgr.Movies)
                {
                    Console.WriteLine(movie.MovieDescription());
                }

                UI.Filter();
                var filterOption = Console.ReadKey(true).Key;
                Console.WriteLine();

                switch (filterOption)
                {
                    case ConsoleKey.D1:
                        movieMgr.GetSingleMovie();
                        break;
                    case ConsoleKey.D2:
                        movieMgr.GetMoviesPerGenre();
                        break;
                    case ConsoleKey.D3:
                        movieMgr.GetMoviesLessThan120Min();
                        break;
                    case ConsoleKey.D4:
                        movieMgr.CreateMovieStringArray();
                        break;
                    case ConsoleKey.D5:
                        movieMgr.CreateMovieTitleString();
                        break;
                    case ConsoleKey.D6:
                        movieMgr.CustomFilter();
                        break;
                    case ConsoleKey.D7:
                        loop = false;
                        Console.WriteLine("Exiting client.");
                        break;
                }

                Console.WriteLine(Environment.NewLine + "Press enter to continue.");
                Console.ReadKey();

            } while (loop);
        }
    }
}
