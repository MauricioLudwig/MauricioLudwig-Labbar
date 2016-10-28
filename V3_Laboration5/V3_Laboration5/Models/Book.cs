using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V3_Laboration5.DataStores.Repositories;

namespace V3_Laboration5.Models
{
    class Book : IMediaProperties
    {
        public GenreType Genre { get; set; }

        public enum GenreType
        {
            Fiction = 1,
            Comedy,
            Drama,
            Horror,
            Dystopia,
            Fantasy
        }

        private int pages;

        public int Pages
        {
            get { return pages; }
            set
            {
                if (pages < 1)
                    pages = 0;
                pages = value;                
            }
        }

        public string UniqueID { get; set; }

        public string Creator { get; set; }

        public string Title { get; set; }

        public static string PrintHeader()
        {
            return String.Format("{0, 20} {1, 20} {2, 20} {3, 20}",
                "Author", "Book", "Pages", "Genre");
        }

        public string PrintAttributes()
        {
            return String.Format("{0, 20} {1, 20} {2, 20} {3, 20}",
                Creator, Title, Pages, Genre);
        }

    }
}
