using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2_Laboration4
{
    class Menus
    {

        public int Choice { get; private set; }

        public void MainMenu()
        {
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Motorcycle");
            Console.WriteLine("3. Buy/Sell");
            Console.WriteLine("4. Exit Program");
            Console.WriteLine();

            Choice = ValidateInput.Integer(1, 4);
        }

        public void VehicleMenu()
        {
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Remove");
            Console.WriteLine("3. Show Inventory");
            Console.WriteLine("4. Return");
            Console.WriteLine();

            Choice = ValidateInput.Integer(1, 4);
        }

        public void BuyOrSellMenu()
        {
            Console.WriteLine("1. Buy");
            Console.WriteLine("2. Sell");
            Console.WriteLine("3. Return");

            Choice = ValidateInput.Integer(1, 3);
        }

        public void BuyVehicle()
        {

        }

    }
}
