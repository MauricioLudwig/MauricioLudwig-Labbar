using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4_Laboration7.StoreManager
{
    class Customer
    {

        public static List<Product> shoppingCart { get; set; }

        static Customer()
        {
            shoppingCart = new List<Product>();
        }

        public static void PrintShoppingCart()
        {

            Console.Clear();

            if (shoppingCart.Count < 1)
                Console.WriteLine("No products!");
            else
            {
                int totalSum = 0;
                Console.WriteLine("Your Products" + Environment.NewLine);

                foreach (var product in shoppingCart)
                {
                    Console.WriteLine(product.ProductParameterValues());
                    totalSum += product.Price;
                }

                Console.WriteLine("Total sum: {0} USD", totalSum);
            }

            Console.ReadKey();
        }
    }
}
