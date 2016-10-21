using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2_Laboration4
{
    public class ExternalVendor
    {

        public List<Car> VendorsCars { get; set; }
        public List<Motorcycle> VendorsMotorcycles { get; set; }

        public ExternalVendor()
        {
            VendorsCars = new List<Car>()
            {
                new Car { Manufacturer = "Honda",  Model = "X20",  Year = 2011, Color = "Black",  Price = 1000, IsSedan = true,  Category = "Car" },
                new Car { Manufacturer = "Toyota", Model = "S10",  Year = 2011, Color = "Blue",   Price = 1000, IsSedan = false, Category = "Car" },
                new Car { Manufacturer = "Volvo",  Model = "L515", Year = 1999, Color = "Green",  Price = 2000, IsSedan = true,  Category = "Car" },
                new Car { Manufacturer = "Testa",  Model = "KL50", Year = 2003, Color = "Red",    Price = 2000, IsSedan = true,  Category = "Car" },
                new Car { Manufacturer = "Nissan", Model = "RET1", Year = 2014, Color = "Yellow", Price = 3000, IsSedan = false, Category = "Car" },
            };

            VendorsMotorcycles = new List<Motorcycle>()
            {
                new Motorcycle { Manufacturer = "Volvo",    Model = "SE10", Year = 2011, Color = "Purple", Price = 5000 , Type = "Cruiser",    Category = "Motorcycle" },
                new Motorcycle { Manufacturer = "Porsche",  Model = "F20",  Year = 1980, Color = "White",  Price = 8000 , Type = "Sport Bike", Category = "Motorcycle" },
                new Motorcycle { Manufacturer = "Mercedes", Model = "TRE1", Year = 2016, Color = "Black",  Price = 12000, Type = "Scooter",    Category = "Motorcycle" },
                new Motorcycle { Manufacturer = "SAAB",     Model = "KI0",  Year = 2000, Color = "Green",  Price = 20000, Type = "Cruiser",    Category = "Motorcycle" },
                new Motorcycle { Manufacturer = "Volvo",    Model = "X11",  Year = 1990, Color = "Red",    Price = 35000, Type = "Scooter",    Category = "Motorcycle" },
            };
        }

    }
}
