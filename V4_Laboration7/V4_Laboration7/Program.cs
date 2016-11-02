using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4_Laboration7
{
    class Program
    {
        // Vecka 4, Laboration 7
        // Futuristic Store App
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
