using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V6_Laboration14
{
    class Book : Publication
    {
        public Genres Genre { get; set; }
        public int Pages { get; set; }
        
        public enum Genres
        {
            Fantasy = 1,
            Horror,
            Mystery,
            SciFi            
        }

        public override string PrintDescription()
        {
            return String.Format("{0}\nPages: {1}\nGenre: {2}",
                base.PrintDescription(),
                Pages,
                Genre);
        }
    }
}
