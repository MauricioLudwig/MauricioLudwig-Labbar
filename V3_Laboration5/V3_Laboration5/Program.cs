using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V3_Laboration5
{
    // Media Manager
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.Start();

            Console.Clear();
            Console.WriteLine("You have reached the end of the program.");
            Console.ReadKey();
        }
    }
}
