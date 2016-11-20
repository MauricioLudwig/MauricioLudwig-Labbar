using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V6_Laboration16.Models;

namespace V6_Laboration16.GUI
{
    class UI
    {

        public static Product AddProduct()
        {
            TextAndColor.LineBreak();

            Product newProduct = new Product();

            Console.Write("Name: ");
            newProduct.Name = Console.ReadLine();

            Console.Write("Price: ");
            newProduct.Price = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSelect Category\n");
            newProduct.Category = GetProductCategory();

            return newProduct;
        }

        public static Product.Categories GetProductCategory()
        {
            foreach (var category in Enum.GetValues(typeof(Product.Categories)))
            {
                Console.WriteLine("{0} - {1}", (int)category, category);
            }

            Console.Write("\nCategory: ");
            int index = int.Parse(Console.ReadLine());

            return (Product.Categories)index;
        }

        public static void PrintProducts(List<Product> products)
        {
            TextAndColor.LineBreak();

            int index = 1;

            Console.WriteLine("{0,-15}{1}\n",
                "Index",
                Product.PrintProductParameters());
            
            foreach (var product in products)
            {
                Console.WriteLine("{0,-15}{1}",
                    index++,
                    product.PrintProductInfo());
            }
        }

        public static int GetProductIndex(string message)
        {
            Console.Write(Environment.NewLine + message + "(index): ");
            int index = int.Parse(Console.ReadLine());
            return index;
        }

        public static int PrintProductNames(List<Product> products)
        {
            TextAndColor.LineBreak();

            int index = 1;
            Console.WriteLine("Product Names\n");

            foreach (var product in products)
            {
                Console.WriteLine("{0} - {1}", index++, product.Name);
            }

            Console.WriteLine("\nSelect product: ");

            return int.Parse(Console.ReadLine());
        }

        public static Product UpdateProduct(Product updatedProduct)
        {
            TextAndColor.LineBreak();
            Console.Write("Current name: {0}", updatedProduct.Name);
            Console.Write("\nNew name: ");
            updatedProduct.Name = Console.ReadLine();
            Console.Write("Current Price: {0}", updatedProduct.Price);
            Console.Write("\nNew price: ");
            updatedProduct.Price = int.Parse(Console.ReadLine());
            Console.WriteLine("\nNew category:");
            updatedProduct.Category = GetProductCategory();

            return updatedProduct;
        }
    }
}
