using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V6_Laboration14.Manager
{
    class ListManager
    {
        public List<Author> Authors { get; set; }
        public List<Publication> Books { get; set; }
        public List<Publication> Magazines { get; set; }
        public List<Publication> Papers { get; set; }
        public List<Publication> Publications { get; set; }
        private List<Publication> SearchQuery { get; set; }

        public ListManager()
        {
            #region Authors
            Authors = new List<Author>()
            {
                new Author { Name = "Scapigliata",    Age = 22 },
                new Author { Name = "Kazuo Ishiguro", Age = 34 },
                new Author { Name = "Dante",          Age = 62 },
                new Author { Name = "George Orwell",  Age = 18 },
                new Author { Name = "Marcel Proust",  Age = 24 },
                new Author { Name = "David Gemmell",  Age = 50 },
            };
            #endregion

            #region Books
            Books = new List<Publication>()
            {
                new Book
                {
                    Author = Authors.SingleOrDefault(author => author.Name.Equals("Scapigliata")),
                    Title = "The Time Masters",
                    Genre = Book.Genres.Fantasy,
                    Pages = 300,
                    ReleaseDate = new DateTime(2017,12,12)
                },
                new Book
                {
                    Author = Authors.SingleOrDefault(author => author.Name.Equals("Dante")),
                    Title = "Divine Comedy",
                    Genre = Book.Genres.Mystery,
                    Pages = 500,
                    ReleaseDate = new DateTime(2012,12,1)
                }
            };
            #endregion

            #region Magazines
            Magazines = new List<Publication>()
            {
                new Magazine
                {
                    Author = Authors.SingleOrDefault(author => author.Name.Equals("George Orwell")),
                    Title = "Pigs and a Farm",
                    Color = "Black",
                    ReleaseDate = new DateTime(2000,8,8)
                },
                new Magazine
                {
                    Author = Authors.SingleOrDefault(author => author.Name.Equals("Kazuo Ishiguro")),
                    Title = "The Remains of the Year",
                    Color = "Red",
                    ReleaseDate = new DateTime(2019,10,11)
                }
            };
            #endregion

            #region Papers
            Papers = new List<Publication>()
            {
                new Paper()
                {
                    Author = Authors.SingleOrDefault(author => author.Name.Equals("Marcel Proust")),
                    Title = "In Search of Lost Time",
                    Issue = 1,
                    ReleaseDate = new DateTime(2016,11,28)
                },
                new Paper()
                {
                    Author = Authors.SingleOrDefault(author => author.Name.Equals("David Gemmell")),
                    Title = "Legend",
                    Issue = 2,
                    ReleaseDate = new DateTime(2010,10,10)
                }
            };
            #endregion

            Publications = new List<Publication>();
            SearchQuery = new List<Publication>();
        }

        public void PrintPublications(string search)
        {
            Publications.Clear();
            Publications.AddRange(Books);
            Publications.AddRange(Magazines);
            Publications.AddRange(Papers);

            SearchQuery = Publications
                .Where(publication => publication.Author.Name.ToLower().Contains(search.ToLower()))
                .OrderBy(publication => publication.Title)
                .ToList();

            if (SearchQuery == null || SearchQuery.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Environment.NewLine + "No matches found.");
                Console.ResetColor();
            }
            else
            {
                foreach (var publication in SearchQuery)
                {
                    Console.WriteLine(Environment.NewLine + "--------------------------------" + Environment.NewLine);
                    Console.WriteLine(publication.PrintDescription());
                }
            }

            Console.WriteLine(Environment.NewLine + "--------------------------------");
            Console.WriteLine(Environment.NewLine + "Press enter to search again.");
        }
    }
}
