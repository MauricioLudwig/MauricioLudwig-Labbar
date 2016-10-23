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
        public List<Vehicle> AllVehicles { get; set; }
        public ExternalVendor externalVendor { get; set; }

        public VehicleManager()
        {

            #region Car Objects
            Cars = new List<Car>()
            {
                new Car { Manufacturer = "Porsche",    Model = "918 Spider",  Color = "Black", Price = 1000000, IsSedan = true,  HorsePower = 400,  StockCategory = "C", StockIndex = 1 },
                new Car { Manufacturer = "Volkswagen", Model = "Passat B8",   Color = "Gray",  Price = 250000,  IsSedan = false, HorsePower = 700,  StockCategory = "C", StockIndex = 2 },
                new Car { Manufacturer = "Porsche",    Model = "718 Boxster", Color = "White", Price = 1250000, IsSedan = true,  HorsePower = 1100, StockCategory = "C", StockIndex = 3 },
                new Car { Manufacturer = "Volvo",      Model = "V70",         Color = "Black", Price = 150000,  IsSedan = false, HorsePower = 400,  StockCategory = "C", StockIndex = 4 }
            };
            #endregion

            #region Motorcycle Objects
            Motorcycles = new List<Motorcycle>()
            {
                new Motorcycle { Manufacturer = "Harley",    Model = "S500",  Year = 2011, Color = "Green", Price = 25000, Type = "Sport Bike", StockCategory = "M", StockIndex = 1 },
                new Motorcycle { Manufacturer = "Kawasaki",  Model = "L1000", Year = 1997, Color = "Red",   Price = 40000, Type = "Sport Bike", StockCategory = "M", StockIndex = 2 },
                new Motorcycle { Manufacturer = "Gladiator", Model = "X10",   Year = 2011, Color = "Blue",  Price = 60000, Type = "Scooter",    StockCategory = "M", StockIndex = 3 },
                new Motorcycle { Manufacturer = "Suzuki",    Model = "K50",   Year = 2015, Color = "White", Price = 80000, Type = "Scooter",    StockCategory = "M", StockIndex = 4 }
            };
            #endregion

            externalVendor = new ExternalVendor();

        }

        #region Add Car
        public void AddCar()
        {
            Car newCar = new Car();

            Console.Write("Manufacturer: ");
            newCar.Manufacturer = Console.ReadLine();

            Console.Write("Model: ");
            newCar.Model = Console.ReadLine();

            Console.Write("Color: ");
            newCar.Color = Console.ReadLine();

            Console.Write("Price: ");
            newCar.Price = ValidateInput.Integer(1);

            Console.Write("Sedan (y/n)? Any other key assigns no automatically: ");
            newCar.IsSedan = Console.ReadLine().ToLower() == "y" ? true : false;

            Console.Write("Horsepower: ");
            newCar.HorsePower = ValidateInput.Integer(1);

            int[] StockIndexArray = Cars
                .Select(car => car.StockIndex)
                .ToArray();

            newCar.StockCategory = "C";

            newCar.StockIndex = ++StockIndexArray[StockIndexArray.Length - 1];

            Cars.Add(newCar);

            Console.WriteLine("New car ({0}) added. Press enter to return.", newCar.StockID());
            Console.ReadKey();
        }
        #endregion

        #region Add Motorcycle
        public void AddMotorcycle()
        {
            Motorcycle newMotorcycle = new Motorcycle();

            Console.Write("Manufacturer: ");
            newMotorcycle.Manufacturer = Console.ReadLine();

            Console.Write("Model: ");
            newMotorcycle.Model = Console.ReadLine();

            Console.Write("Color: ");
            newMotorcycle.Color = Console.ReadLine();

            Console.Write("Price: ");
            newMotorcycle.Price = ValidateInput.Integer(1);

            Console.Write("Year: ");
            newMotorcycle.Year = ValidateInput.Integer(1);

            Console.Write("Type of motorcycle: ");
            newMotorcycle.Type = Console.ReadLine();

            int[] StockIDs = Motorcycles
                .Select(motorcycle => motorcycle.StockIndex)
                .ToArray();

            newMotorcycle.StockCategory = "M";

            newMotorcycle.StockIndex = ++StockIDs[StockIDs.Length - 1];

            Motorcycles.Add(newMotorcycle);

            Console.WriteLine("New motorcycle ({0}) added. Press enter to return.", newMotorcycle.StockID());
            Console.ReadKey();
        }
        #endregion

        #region Remove Vehicle
        public void RemoveVehicle()
        {

            bool loop = true;
            string input;

            do
            {
                DisplayAllVehicles();

                TextColor.Green("Select vehicle (ID) to remove or press enter to return to main menu: ");
                input = Console.ReadLine();

                if (String.IsNullOrEmpty(input))
                    loop = false;
                else
                {
                    if (input[0] == 'C')
                    {
                        try
                        {
                            Car removeCar = Cars
                                .SingleOrDefault(car => String.Equals(car.StockID(), input));
                            Cars.Remove(removeCar);
                            Console.WriteLine("Car {0} {1} ({2}) removed. Press enter to continue.",
                                removeCar.Manufacturer, removeCar.Model, removeCar.StockID());
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input. Try again.");
                        }
                    }
                    else if (input[0] == 'M')
                    {
                        try
                        {
                            Motorcycle removeMotorcycle = Motorcycles
                                .SingleOrDefault(motorcycle => String.Equals(motorcycle.StockID(), input));
                            Motorcycles.Remove(removeMotorcycle);
                            Console.WriteLine("Motorcycle {0} {1} ({2}) removed. Press enter to continue.",
                                removeMotorcycle.Manufacturer, removeMotorcycle.Model, removeMotorcycle.StockID());
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input. Try again.");
                        }
                    }
                    else
                        Console.WriteLine("Invalid Input. Try again.");
                    Console.ReadKey();
                }
            } while (loop);
        }
        #endregion

        #region Buy New Vehicle
        public void BuyNewVehicle()
        {

            DisplayVendorsVehicles(true);
            Console.Write("Select vehicle by ID to purchase: ");
            string input = Console.ReadLine();

            try
            {
                if (input[0] == 'C')
                {
                    Car purchasedCar = externalVendor.NewCarsForSale
                        .SingleOrDefault(newCarForSale => String.Equals(newCarForSale.StockIndex.ToString(), input[1].ToString()));

                    int[] StockIndexArray = Cars
                        .Select(car => car.StockIndex)
                        .ToArray();

                    purchasedCar.StockIndex = ++StockIndexArray[StockIndexArray.Length - 1];

                    Cars.Add(purchasedCar);
                    externalVendor.NewCarsForSale.Remove(purchasedCar);

                    Console.WriteLine("Purchase complete.");
                }
                else if (input[0] == 'M')
                {
                    Motorcycle purchasedMotorcycle = externalVendor.NewMotorcyclesForSale
                        .SingleOrDefault(newMotorcycleForSale => String.Equals(newMotorcycleForSale.StockIndex.ToString(), input[1].ToString()));

                    int[] StockIndexArray = Motorcycles
                        .Select(motorcycle => motorcycle.StockIndex)
                        .ToArray();

                    purchasedMotorcycle.StockIndex = ++StockIndexArray[StockIndexArray.Length - 1];

                    Motorcycles.Add(purchasedMotorcycle);
                    externalVendor.NewMotorcyclesForSale.Remove(purchasedMotorcycle);

                    Console.WriteLine("Purchase complete.");
                }
                else
                    Console.WriteLine("Invalid input.");
            }
            catch
            {
                Console.WriteLine("Input invalid.");
            }

            Console.ReadKey();
        }
        #endregion

        #region Buy Old Vehicle
        public void BuyOldVehicle()
        {
            DisplayVendorsVehicles(false);
            Console.Write("Select vehicle by ID to purchase: ");
            string input = Console.ReadLine();

            try
            {
                if (input[0] == 'C')
                {
                    Car purchasedCar = externalVendor.OldCarsForSale
                        .SingleOrDefault(oldCarForSale => String.Equals(oldCarForSale.StockIndex.ToString(), input[1].ToString()));

                    int[] StockIndexArray = Motorcycles
                        .Select(motorcycle => motorcycle.StockIndex)
                        .ToArray();

                    purchasedCar.StockIndex = ++StockIndexArray[StockIndexArray.Length - 1];

                    Cars.Add(purchasedCar);
                    externalVendor.OldCarsForSale.Remove(purchasedCar);

                    Console.WriteLine("Purchase complete.");
                }
                else if (input[0] == 'M')
                {
                    Motorcycle purchasedMotorcycle = externalVendor.OldMotorcyclesForSale
                        .SingleOrDefault(oldMotorcycleForSale => String.Equals(oldMotorcycleForSale.StockIndex.ToString(), input[1].ToString()));

                    int[] StockIndexArray = Motorcycles
                        .Select(motorcycle => motorcycle.StockIndex)
                        .ToArray();

                    purchasedMotorcycle.StockIndex = ++StockIndexArray[StockIndexArray.Length - 1];

                    Motorcycles.Add(purchasedMotorcycle);
                    externalVendor.OldMotorcyclesForSale.Remove(purchasedMotorcycle);

                    Console.WriteLine("Purchase complete.");
                }
                else
                    Console.WriteLine("Invalid input.");
            }
            catch
            {
                Console.WriteLine("Input invalid.");
            }

            Console.ReadKey();
        }
        #endregion

        #region Sell Vehicle
        public void SellVehicle()
        {
            DisplayAllVehicles();
            TextColor.Green("Select vehicle (ID) you wish to sell: ");
            string input = Console.ReadLine();

            try
            {
                if (input[0] == 'C')
                {
                    Car sellCar = Cars
                        .Single(car => String.Equals(car.StockID(), input));
                    Console.WriteLine("Is the car new (y/n)? Any other key terminates the operation.");
                    string newQuery = Console.ReadLine();
                    if (newQuery.ToLower() == "y")
                    {
                        Console.WriteLine("Car {0} {1} ({2}) sold as new for {3} kr.",
                            sellCar.Manufacturer, sellCar.Model, sellCar.StockID(), sellCar.Price);

                        Cars.Remove(sellCar);
                    }
                    else if (newQuery.ToLower() == "n")
                    {
                        Console.WriteLine("Car {0} {1} ({2}) sold as used for {3} kr. Original price was {4} kr.",
                            sellCar.Manufacturer, sellCar.Model, sellCar.StockID(), sellCar.AdjustedPrice(), sellCar.Price);

                        Cars.Remove(sellCar);
                    }
                }
                else if (input[0] == 'M')
                {
                    Motorcycle sellMotorcycle = Motorcycles
                        .Single(motorcycle => String.Equals(motorcycle.StockID(), input));
                    Console.WriteLine("Is the motorcycle new (y/n)? Any other key terminates the operation.");
                    string newQuery = Console.ReadLine();
                    if (newQuery.ToLower() == "y")
                    {
                        Console.WriteLine("Motorcycle {0} {1} ({2}) sold as new for {3} kr.",
                            sellMotorcycle.Manufacturer, sellMotorcycle.Model, sellMotorcycle.StockID(), sellMotorcycle.Price);

                        Motorcycles.Remove(sellMotorcycle);
                    }
                    else if (newQuery.ToLower() == "n")
                    {
                        Console.WriteLine("Motorcycle {0} {1} ({2}) sold as used for {3} kr. Original price was {4} kr.",
                            sellMotorcycle.Manufacturer, sellMotorcycle.Model, sellMotorcycle.StockID(), sellMotorcycle.AdjustedPrice(), sellMotorcycle.Price);

                        Motorcycles.Remove(sellMotorcycle);
                    }
                }
                else
                    Console.WriteLine("Invalid input. Try again.");
            }
            catch
            {
                Console.WriteLine("Invalid input. Try again..");
            }
            Console.ReadKey();
        }
        #endregion

        #region View Inventory
        public void ViewInventory()
        {

            bool loop = true;
            string input;
            DisplayAllVehicles();

            do
            {

                TextColor.Green("Sort by model or type \'all\' to display all vehicles or press enter to return to main menu: ");
                input = Console.ReadLine();
                Console.Clear();

                if (input.ToLower() == "all")
                    DisplayAllVehicles();
                else if (String.IsNullOrEmpty(input))
                {
                    loop = false;
                }
                else
                {
                    Vehicle[] subset = AllVehicles
                        .Where(vehicle => vehicle.Model.Contains(input))
                        .ToArray();

                    foreach (var vehicle in subset)
                    {
                        Console.WriteLine(vehicle.VehicleInfo());
                        Console.WriteLine();
                    }

                    if (!(subset.Length > 0))
                        TextColor.Red("No match." + Environment.NewLine + Environment.NewLine);
                }
            } while (loop);
        }
        #endregion

        #region Display All Vehicles
        public void DisplayAllVehicles()
        {
            AllVehicles = new List<Vehicle>();
            AllVehicles.AddRange(Cars);
            AllVehicles.AddRange(Motorcycles);

            Console.Clear();

            TextColor.Green(Vehicle.VehicleLabel() + Environment.NewLine + Environment.NewLine);
            foreach (var vehicle in AllVehicles)
            {
                Console.WriteLine(vehicle.VehicleInfo());
                Console.WriteLine();
            }
        }
        #endregion

        #region Display Vendors Vehicles
        public void DisplayVendorsVehicles(bool newVehicle)
        {
            externalVendor.NewVehicles = new List<Vehicle>();
            externalVendor.OldVehicles = new List<Vehicle>();

            if (newVehicle == true)
            {
                externalVendor.NewVehicles.AddRange(externalVendor.NewCarsForSale);
                externalVendor.NewVehicles.AddRange(externalVendor.NewMotorcyclesForSale);

                foreach (var vehicle in externalVendor.NewVehicles)
                {
                    Console.WriteLine(vehicle.VehicleInfo());
                    Console.WriteLine();
                }
            }
            else
            {
                externalVendor.OldVehicles.AddRange(externalVendor.OldCarsForSale);
                externalVendor.OldVehicles.AddRange(externalVendor.OldMotorcyclesForSale);

                foreach (var vehicle in externalVendor.OldVehicles)
                {
                    Console.WriteLine(vehicle.VehicleInfo());
                    Console.WriteLine();
                }
            }
        }
        #endregion

    }
}
