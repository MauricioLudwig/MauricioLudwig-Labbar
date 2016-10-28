using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V3_Laboration5.Models;

namespace V3_Laboration5.DataStores
{
    class MediaLists
    {

        private static List<Music> music = new List<Music>();
        private static List<Book> books = new List<Book>();

        public static List<Music> Music
        {
            get
            {
                if (music == null)
                    music = new List<Music>();
                return music;
            }       
        }

        public static List<Book> Books
        {
            get
            {
                if (books == null)
                    books = new List<Book>();
                return books;
            }
        }
    }
}
