using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V6_Laboration10
{
    public class BookFilterMgr
    {

        public static bool IsNovel(Book book)
        {
            return book.Pages >= 100;
        }

        public static bool IsShortStory(Book book)
        {
            return book.Pages < 100;
        }

        public static bool IsGenreMystery(Book book)
        {
            return book.Genre == Book.Genres.Mystery;
        }

        public static bool IsGenreFantasy(Book book)
        {
            return book.Genre == Book.Genres.Fantasy;
        }

        public static bool IsGenreRomance(Book book)
        {
            return book.Genre == Book.Genres.Romance;
        }

        public static bool IsCheap(Book book)
        {
            return book.Price <= 50;
        }

        public static bool IsExpensive(Book book)
        {
            return book.Price > 50;
        }
    }
}
