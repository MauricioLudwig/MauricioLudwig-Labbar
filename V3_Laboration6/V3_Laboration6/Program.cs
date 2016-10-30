using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V3_Laboration6
{
    class Program
    {
        // Game Title Here
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Start();

            Console.Clear();
            Console.WriteLine("You have reached the end of the program.");
            Console.ReadKey();
        }
    }
}
