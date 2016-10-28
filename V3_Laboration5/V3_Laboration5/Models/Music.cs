using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V3_Laboration5.DataStores.Repositories;

namespace V3_Laboration5.Models
{
    class Music : IMediaProperties
    {

        public GenreType Genre { get; set; }

        public enum GenreType
        {
            Pop = 1,
            Electro,
            Rock,
            Jazz,
            Country,
            Blues
        }

        public int Length { get; set; }
        public string Creator { get; set;}
        public string Title { get; set; }

        public static string PrintHeader()
        {
            return String.Format("{0, 20} {1, 20} {2, 20} {3, 20}",
                "Artist", "Song", "Length", "Genre");
        }

        public string PrintAttributes()
        {
            return String.Format("{0, 20} {1, 20} {2, 20} {3, 20}",
                Creator, Title, Length, Genre);
        }
    }
}
