using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V3_Laboration5.Models;
using V3_Laboration5.Esthetics;

namespace V3_Laboration5.DataStores.Repositories
{
    class MusicRepository : IRepository
    {

        public void AddMedia(object newObject)
        {
            MediaLists.Music.Add((Music)newObject);
        }

        public void RemoveMedia(object removeObject)
        {
            MediaLists.Music.Remove((Music)removeObject);
        }

        public int PrintList()
        {
            int i = 0;
            TextAndColor.Header("i" + Music.PrintHeader());
            foreach (var music in MediaLists.Music)
            {
                Console.WriteLine("{0}" + music.PrintAttributes(), ++i);
            }

            return i;
        }
    }
}
