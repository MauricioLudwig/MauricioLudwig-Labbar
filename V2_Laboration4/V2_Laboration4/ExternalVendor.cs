using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2_Laboration4
{
    public class ExternalVendor
    {

        public List<Car> NewCarsForSale { get; set; }
        public List<Car> OldCarsForSale { get; set; }
        public List<Motorcycle> NewMotorcyclesForSale { get; set; }
        public List<Motorcycle> OldMotorcyclesForSale { get; set; }
        public List<Vehicle> NewVehicles { get; set; }
        public List<Vehicle> OldVehicles { get; set; }

        public ExternalVendor()
        {
            NewCarsForSale = new List<Car>()
            {
                new Car { Manufacturer = "Honda",  Model = "X20",  Color = "Black",  Price = 1000, IsSedan = true,  HorsePower = 700, StockIndex = 1, StockCategory = "C" },
                new Car { Manufacturer = "Toyota", Model = "S10",  Color = "Blue",   Price = 1000, IsSedan = false, HorsePower = 900, StockIndex = 2, StockCategory = "C" }
            };

            OldCarsForSale = new List<Car>()
            {
                new Car { Manufacturer = "Volvo",  Model = "L515", Color = "Green",  Price = 2000, IsSedan = true, HorsePower = 500, StockIndex = 3, StockCategory = "C" },
                new Car { Manufacturer = "Testa",  Model = "KL50", Color = "Red",    Price = 2000, IsSedan = true, HorsePower = 200, StockIndex = 4, StockCategory = "C" }
            };

            NewMotorcyclesForSale = new List<Motorcycle>()
            {
                new Motorcycle { Manufacturer = "Volvo",    Model = "SE10", Year = 2011, Color = "Purple", Price = 5000 , Type = "Cruiser",    StockIndex = 1, StockCategory = "M" },
                new Motorcycle { Manufacturer = "Porsche",  Model = "F20",  Year = 1980, Color = "White",  Price = 8000 , Type = "Sport Bike", StockIndex = 2, StockCategory = "M" }
            };

            OldMotorcyclesForSale = new List<Motorcycle>()
            {
                new Motorcycle { Manufacturer = "SAAB",     Model = "KI0",  Year = 2000, Color = "Green",  Price = 20000, Type = "Cruiser", StockIndex = 3, StockCategory = "M" },
                new Motorcycle { Manufacturer = "Volvo",    Model = "X11",  Year = 1990, Color = "Red",    Price = 35000, Type = "Scooter", StockIndex = 4, StockCategory = "M" }
            };
        }
    }
}
