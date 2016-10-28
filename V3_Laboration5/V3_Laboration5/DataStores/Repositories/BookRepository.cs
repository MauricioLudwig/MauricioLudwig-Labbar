using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V3_Laboration5.Models;
using V3_Laboration5.Esthetics;

namespace V3_Laboration5.DataStores.Repositories
{
    class BookRepository : IRepository
    {
        public void AddMedia(object newObject)
        {
            MediaLists.Books.Add((Book)newObject);
        }

        public void RemoveMedia(object removeObject)
        {
            MediaLists.Books.Remove((Book)removeObject);
        }

        public int PrintList()
        {
            int i = 0;

            TextAndColor.Header("i" + Book.PrintHeader());
            foreach (var book in MediaLists.Books)
            {
                Console.WriteLine("{0}" + book.PrintAttributes(), ++i);
            }

            return i;
        }
    }
}
