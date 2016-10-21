using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2_Laboration4
{
    class ExternalVendor
    {

        public List<Car> VendorsCars { get; set; }
        public List<Motorcycle> VendorsMotorcycles { get; set; }

        public ExternalVendor()
        {
            VendorsCars = new List<Car>()
            {
                new Car { Manufacturer = "", Model = "", Year = 0, Color = "", Price = 0 },
                new Car { Manufacturer = "", Model = "", Year = 0, Color = "", Price = 0 },
                new Car { Manufacturer = "", Model = "", Year = 0, Color = "", Price = 0 },
                new Car { Manufacturer = "", Model = "", Year = 0, Color = "", Price = 0 },
                new Car { Manufacturer = "", Model = "", Year = 0, Color = "", Price = 0 },
            };

            VendorsMotorcycles = new List<Motorcycle>()
            {
                new Motorcycle { Manufacturer = "", Model = "", Year = 0, Color = "", Price = 0 },
                new Motorcycle { Manufacturer = "", Model = "", Year = 0, Color = "", Price = 0 },
                new Motorcycle { Manufacturer = "", Model = "", Year = 0, Color = "", Price = 0 },
                new Motorcycle { Manufacturer = "", Model = "", Year = 0, Color = "", Price = 0 },
                new Motorcycle { Manufacturer = "", Model = "", Year = 0, Color = "", Price = 0 },
            };
        }

    }
}
