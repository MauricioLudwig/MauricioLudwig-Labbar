using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V6_Laboration14
{
    abstract class Publication
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public DateTime ReleaseDate { get; set; }

        public string DateTimeFormat()
        {
            return String.Format("{0:dddd, MMMM d, yyyy}", ReleaseDate);
        }

        public virtual string PrintDescription()
        {
            return String.Format("{0}\n{1}\n\nRelease: {2}",
                Title,
                Author.AuthorDescription(),
                DateTimeFormat());
        }
    }
}
