using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V6_Laboration10
{
    class BookManager
    {
        public List<Book> Books { get; set; }

        public BookManager()
        {
            Books = new List<Book>()
            {
                new Book { Title = "Killing Bullet", Pages = 300, Price = 49.95, Genre = Book.Genres.Crime},
                new Book { Title = "Trump's America", Pages = 100, Price = 0.99, Genre = Book.Genres.Dystopia},
                new Book { Title = "Sauron's Revenge", Pages = 250, Price = 79.95, Genre = Book.Genres.Fantasy},
                new Book { Title = "The Witch", Pages = 500, Price = 95.95, Genre = Book.Genres.Horror},
                new Book { Title = "Star Force", Pages = 50, Price = 29.95, Genre = Book.Genres.Romance},
                new Book { Title = "C#", Pages = 50, Price = 39.95, Genre = Book.Genres.Mystery}
            };
        }

        public void PrintWhere(BookFilter filter)
        {

            foreach (var book in Books)
            {
                if (filter(book))
                    Console.WriteLine(book.Title);
            }
        }
    }
}
