using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V6_Laboration12.Models
{
    class Movie
    {
        public string Title { get; set; }
        public int Length { get; set; }
        public Genres Genre { get; set; }

        public enum Genres
        {
            Comedy = 1,
            Adventure,
            Fantasy,
            Drama,
            Family
        }

        public static string MovieParameters()
        {
            return String.Format("{0,-25}{1,-25}{2,-25}", "Title", "Length (min)", "Genre");
        }

        public string MovieDescription()
        {
            return String.Format("{0,-25}{1,-25}{2,-25}", Title, Length, Genre);
        }
    }
}
