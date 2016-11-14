using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V6_Laboration10
{
    class Runtime
    {

        public void Start()
        {
            BookManager manager = new BookManager();

            BookFilter isNovel = BookFilterMgr.IsNovel;
            BookFilter isShortStory = BookFilterMgr.IsShortStory;
            BookFilter isGenreMystery = BookFilterMgr.IsGenreMystery;
            BookFilter isGenreFantasy = BookFilterMgr.IsGenreFantasy;
            BookFilter isGenreRomance = BookFilterMgr.IsGenreRomance;
            BookFilter isCheap = BookFilterMgr.IsCheap;
            BookFilter isExpensive = BookFilterMgr.IsExpensive;

            Console.WriteLine("\nNovels: ");
            manager.PrintWhere(isNovel);

            Console.WriteLine("\nShort Stories:");
            manager.PrintWhere(isShortStory);

            Console.WriteLine("\nIs Mystery:");
            manager.PrintWhere(isGenreMystery);

            Console.WriteLine("\nIs Fantasy:");
            manager.PrintWhere(isGenreFantasy);

            Console.WriteLine("\nIs Romance:");
            manager.PrintWhere(isGenreRomance);

            Console.WriteLine("\nIs Cheap < 50 :-");
            manager.PrintWhere(isCheap);

            Console.WriteLine("\nIs expensive > 50 :-");
            manager.PrintWhere(isExpensive);

        }
    }
}
