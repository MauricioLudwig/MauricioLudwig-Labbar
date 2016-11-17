using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V6_Laboration14.Manager;

namespace V6_Laboration14
{
    class Client
    {
        public void Start()
        {

            #region Simple Instances
            /*
            Author author1 = new Author() { Name = "Damien", Age = 25 };
            Author author2 = new Author() { Name = "Franz Kafka", Age = 25 };
            Author author3 = new Author() { Name = "Joseph Conrad", Age = 44 };

            Book book = new Book()
            {
                Author = author1,
                Title = "Pavel",
                Genre = Book.Genres.Horror,
                Pages = 300,
                ReleaseDate = new DateTime(2016, 11, 28)
            };

            Magazine magazine = new Magazine()
            {
                Author = author2,
                Title = "The Trial",
                Color = "Black",
                ReleaseDate = new DateTime(2016, 10, 20)
            };

            Paper paper = new Paper()
            {
                Author = author3,
                Title = "Nat Geo",
                Issue = 1,
                ReleaseDate = new DateTime(2017, 1, 1)
            };

            Console.WriteLine("\n-- Book--\n\n" + book.PrintDescription());
            Console.WriteLine("\n-- Magazine--\n\n" + magazine.PrintDescription());
            Console.WriteLine("\n-- Paper--\n\n" + paper.PrintDescription());
            */
            #endregion

            ListManager listMgr = new ListManager();

            bool loop = true;
            string input;

            while (loop)
            {
                Console.Clear();

                Console.Write("Search publications by author: ");
                input = Console.ReadLine();

                listMgr.PrintPublications(input);

                Console.ReadKey();
            }

        }
    }
}
