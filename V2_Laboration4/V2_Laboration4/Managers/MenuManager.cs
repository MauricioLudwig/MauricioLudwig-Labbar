using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2_Laboration4
{
    class MenuManager
    {

        public int menuOption { get; private set; }

        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Remove");
            Console.WriteLine("3. Buy");
            Console.WriteLine("4. Sell");
            Console.WriteLine("5. View Inventory");
            Console.WriteLine("6. Exit Program");

            menuOption = ValidateInput.Integer(1, 6);
            Console.Clear();
        }

        public void AddVehicleMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Motorcycle");
            Console.WriteLine("3. Return");

            menuOption = ValidateInput.Integer(1, 3);
            Console.Clear();
        }

        public void BuyVehicleMenu()
        {
            Console.Clear();
            Console.WriteLine("1. New");
            Console.WriteLine("2. Used");
            Console.WriteLine("3. Return");

            menuOption = ValidateInput.Integer(1, 3);
            Console.Clear();
        }

    }
}
