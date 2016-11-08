using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V5_Laboration8
{
    class ProductManager
    {

        public List<IProduct> Items { get; set; }

        public ProductManager()
        {
            Items = new List<IProduct>()
            {
                new Item { ID = 1, Name = "Pepsi", Price = 9.5 },
                new Item { ID = 2, Name = "Fanta", Price = 4.2 },
                new Item { ID = 2, Name = "Coca Cola Zero", Price = 1001 },
                new Item { ID = 2, Name = "7 UP", Price = 10.1 }
            };
        }

        public string FormatProductNames(string[] strings)
        {
            string result = String.Empty;
            int index = 0;

            foreach (var mString in strings)
            {
                index++;
                if (index < strings.Length)
                {
                    result += mString + ", ";
                }
                else
                    result += mString;
            }
            return result;
        }

        public double PriceCalculation(double[] arrayDouble)
        {
            double result1 = 0;
            double result2 = 0;

            foreach (var productPrice in arrayDouble)
            {
                if (productPrice < 1000)
                    result1 += productPrice;
                else
                    result2 += productPrice;
            }

            result1 *= 1.2;
            result2 *= 0.9;

            return result1 + result2;
        }
    }
}
