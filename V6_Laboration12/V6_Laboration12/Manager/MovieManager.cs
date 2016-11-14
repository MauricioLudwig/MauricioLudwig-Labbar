using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V6_Laboration12.Models;

namespace V6_Laboration12
{
    class MovieManager
    {

        public List<Movie> Movies { get; set; }

        public MovieManager()
        {
            Movies = new List<Movie>()
            {
                new Movie { Title = "12 Angry Men",         Length = 120, Genre = Movie.Genres.Drama       },
                new Movie { Title = "Rat Race",             Length = 140, Genre = Movie.Genres.Comedy      },
                new Movie { Title = "Lost Souls",           Length = 200, Genre = Movie.Genres.Family      },
                new Movie { Title = "Wilson",               Length = 100, Genre = Movie.Genres.Adventure   },
                new Movie { Title = "Lord of the Rings",    Length = 160, Genre = Movie.Genres.Fantasy     },
                new Movie { Title = "Sauron's Revenge",     Length =  80, Genre = Movie.Genres.Fantasy     },
                new Movie { Title = "15 Angry Men",         Length = 220, Genre = Movie.Genres.Drama       },
                new Movie { Title = "Scary Movie 1",        Length = 110, Genre = Movie.Genres.Comedy      },
                new Movie { Title = "Scary Movie 2",        Length = 120, Genre = Movie.Genres.Comedy      }
            };
        }

        public void GetSingleMovie()
        {
            Console.Write("Enter movie title (lower-case letters are permitted): ");
            string input = Console.ReadLine().ToLower();

            Movie singleMovie = Movies
                .Where(movie => String.Equals(movie.Title.ToLower(), input))
                .SingleOrDefault();

            if (singleMovie == null)
                Console.WriteLine("No movie found.");
            else
                Console.WriteLine("Movie found: {0}", singleMovie.MovieDescription());
        }

        public void GetMoviesPerGenre()
        {

            foreach (var genre in Enum.GetValues(typeof(Movie.Genres)))
            {
                Console.WriteLine("{0} - {1}", (int)genre, genre);
            }

            Console.Write(Environment.NewLine + "Genre: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Environment.NewLine + Movie.MovieParameters() + Environment.NewLine);

            try
            {
                List<Movie> movies = Movies
                    .Where(movie => movie.Genre == (Movie.Genres)input)
                    .ToList();

                foreach (var movie in movies)
                {
                    Console.WriteLine(movie.MovieDescription());
                }
            }
            catch
            {
                Console.WriteLine("Invalid input.");
            }
        }

        public void GetMoviesLessThan120Min()
        {
            List<Movie> movies = Movies
                .Where(movie => movie.Length < 120).ToList();

            Console.WriteLine(Movie.MovieParameters() + Environment.NewLine);

            foreach (var movie in movies)
            {
                Console.WriteLine(movie.MovieDescription());
            }
        }

        public void CreateMovieStringArray()
        {
            string[] movieTitles = Movies
                .Select(movie => movie.Title).ToArray();

            Console.WriteLine("Operation complete. Print string array (yY/nN)? ");

            string query = Console.ReadLine().ToLower();

            if (query == "y")
            {
                foreach (var title in movieTitles)
                {
                    Console.WriteLine(title);
                }
            }
        }

        public void CreateMovieTitleString()
        {
            Console.Write("Select movie by title (lower-case letters are permitted): ");
            string input = Console.ReadLine().ToLower();

            string movieTitle = Movies
                .Where(movie => movie.Title.ToLower().Equals(input))
                .Select(movie => movie.Title)
                .FirstOrDefault();

            if (!(String.IsNullOrEmpty(movieTitle)))
            {
                Console.WriteLine("Operation complete. Print movie title (yY/nN)? ");

                string query = Console.ReadLine().ToLower();

                if (query == "y")
                    Console.WriteLine("Single string variable (movie title): {0}", movieTitle);
            }
            else
                Console.WriteLine("No movie found.");
        }

        public void CustomFilter()
        {
            Console.Write("First letter of the movie (lower-case letters are permitted): ");
            string letter = Console.ReadLine().ToLower();

            Console.Write("Movies with a higher or equal playback time than (min): ");
            int length = int.Parse(Console.ReadLine());

            foreach (var genre in Enum.GetValues(typeof(Movie.Genres)))
            {
                Console.WriteLine("{0} - {1}", (int)genre, genre);
            }

            Console.Write("Select genre: ");
            int genreIndex = int.Parse(Console.ReadLine());

            List<Movie> movies = Movies
                .Where(movie => (String.Equals(movie.Title.ToLower()[0], letter[0])) && (length <= movie.Length) && (movie.Genre == (Movie.Genres)genreIndex))
                .ToList();

            if (!(movies.Count == 0))
            {
                Console.WriteLine(Environment.NewLine + "Movies matching criteria:");

                foreach (var movie in movies)
                {
                    Console.WriteLine(movie.MovieDescription());
                }
            }
            else
                Console.WriteLine(Environment.NewLine + "No movies found.");

        }
    }
}
