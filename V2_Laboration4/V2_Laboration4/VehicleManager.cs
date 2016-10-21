using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2_Laboration4
{
    class VehicleManager
    {

        public List<Car> Cars { get; set; }
        public List<Motorcycle> Motorcycles { get; set; }
        public int ShowIndex { get; set; } 

        public VehicleManager()
        {

            #region Car objects
            Cars = new List<Car>()
            {
                new Car { Manufacturer = "Porsche",    Model = "918 Spider",  Year = 2015, Color = "Black", Price = 1000000 },
                new Car { Manufacturer = "Volkswagen", Model = "Passat B8",   Year = 2012, Color = "Gray",  Price = 250000  },
                new Car { Manufacturer = "Porsche",    Model = "718 Boxster", Year = 2002, Color = "White", Price = 1250000 },
                new Car { Manufacturer = "Volvo",      Model = "V70",         Year = 1998, Color = "Black", Price = 150000  },
                new Car { Manufacturer = "Tesla",      Model = "Model X",     Year = 2016, Color = "White", Price = 300000  }
            };
            #endregion

            #region Motorcycle objects
            Motorcycles = new List<Motorcycle>()
            {
                new Motorcycle { Manufacturer = "Harley",    Model = "S500",  Year = 2011, Color = "Green", Price = 25000 },
                new Motorcycle { Manufacturer = "Kawasaki",  Model = "L1000", Year = 1997, Color = "Red",   Price = 40000 },
                new Motorcycle { Manufacturer = "Gladiator", Model = "X10",   Year = 2011, Color = "Blue",  Price = 60000 },
                new Motorcycle { Manufacturer = "Suzuki",    Model = "K50",   Year = 2015, Color = "White", Price = 80000 },
                new Motorcycle { Manufacturer = "REX",       Model = "C101",  Year = 1990, Color = "Green", Price = 75000 }
            };
            #endregion

        }

        public void AddCar()
        {
            Car newCar = new Car();

            Console.Write("Manufacturer: ");
            newCar.Manufacturer = Console.ReadLine();

            Console.Write("Model: ");
            newCar.Model = Console.ReadLine();

            Console.Write("Year: ");
            newCar.Year = ValidateInput.Integer(1);

            Console.Write("Color: ");
            newCar.Color = Console.ReadLine();

            Console.Write("Price: ");
            newCar.Price = ValidateInput.Integer(1);

            Cars.Add(newCar);
        }

        public void AddMotorcycle()
        {
            Motorcycle newMotorcycle = new Motorcycle();

            Console.Write("Manufacturer: ");
            newMotorcycle.Manufacturer = Console.ReadLine();

            Console.Write("Model: ");
            newMotorcycle.Model = Console.ReadLine();

            Console.Write("Year: ");
            newMotorcycle.Year = ValidateInput.Integer(1);

            Console.Write("Color: ");
            newMotorcycle.Color = Console.ReadLine();

            Console.Write("Price: ");
            newMotorcycle.Price = ValidateInput.Integer(1);

            Motorcycles.Add(newMotorcycle);
        }

        public void RemoveCar()
        {
            ShowCars();
            int choice = ValidateInput.Integer(1, ShowIndex);
            TextColor.Red(Environment.NewLine + "Delete ");
            Console.WriteLine("{0}? (yes/no)", Cars[--choice].Manufacturer);
            if (Console.ReadLine().ToLower() == "yes")
            {
                Cars.RemoveAt(choice);
                Console.WriteLine(Environment.NewLine + "Succesfully removed car!");
            }
            else
                Console.WriteLine(Environment.NewLine + "Operation aborted");
        }

        public void RemoveMotorcycle()
        {
            ShowMotorcycles();
            int choice = ValidateInput.Integer(1, ShowIndex);
            TextColor.Red(Environment.NewLine + "Delete ");
            Console.WriteLine("{0}? (yes/no)", Motorcycles[--choice].Manufacturer);
            if (Console.ReadLine().ToLower() == "yes")
            {
                Motorcycles.RemoveAt(choice);
                Console.WriteLine(Environment.NewLine + "Succesfully removed motorcycle!");
            }
            else
                Console.WriteLine(Environment.NewLine + "Operation aborted");
        }

        public void ShowCars()
        {
            ShowIndex = 1;
            TextColor.Yellow(Environment.NewLine + "Inventory: Cars" + Environment.NewLine + Environment.NewLine);
            foreach (var car in Cars)
            {
                Console.Write("{0}. ", ShowIndex++);
                Console.WriteLine(car.VehicleDescription());
                Console.WriteLine();
            }
        }

        public void ShowMotorcycles()
        {
            ShowIndex = 1;
            TextColor.Yellow(Environment.NewLine + "Inventory: Motorcycles" + Environment.NewLine + Environment.NewLine);
            foreach (var motorcycle in Motorcycles)
            {
                Console.Write("{0}. ", ShowIndex);
                Console.WriteLine(motorcycle.VehicleDescription());
                Console.WriteLine();
            }
        }

    }
}
