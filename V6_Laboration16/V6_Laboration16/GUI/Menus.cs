using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V6_Laboration16.GUI
{
    class Menus
    {

        public static void Start()
        {
            Console.WriteLine("1. Using ListProductRepository");
            Console.WriteLine("2. Using FileProductRepository");
            Console.WriteLine("3. Exit Program");
        }

        public static void Product()
        {
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Get Product");
            Console.WriteLine("3. Get All Products");
            Console.WriteLine("4. Update Product");
            Console.WriteLine("5. Delete Product");
            Console.WriteLine("6. Return");
        }
    }
}
