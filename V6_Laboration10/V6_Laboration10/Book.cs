using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V6_Laboration10
{
    public class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }
        public double Price { get; set; }
        public Genres Genre { get; set; }

        public enum Genres
        {
            Fantasy,
            Dystopia,
            Horror,
            Crime,
            Mystery,
            Romance
        }
    }
}
