using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V6_Laboration16.Models
{
    class Product
    {
        private string name;
        private double price;
        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    value = "Unknown";
                name = value;
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 1)
                    value = 1;
                price = value;
            }
        }

        public Categories Category { get; set; }

        public enum Categories
        {
            Software = 1,
            Hardware,
            CloudStorage
        };

        public static string PrintProductParameters()
        {
            return String.Format("{0,-15}{1,-15}{2,-15}",
                "Product", 
                "Price (USD)",
                "Category");
        }

        public string PrintProductInfo()
        {
            return String.Format("{0,-15}{1,-15}{2,-15}", 
                Name, 
                Price, 
                Category);
        }
    }
}
