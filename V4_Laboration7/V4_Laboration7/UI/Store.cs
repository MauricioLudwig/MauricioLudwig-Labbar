﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using V4_Laboration7.ErrorHandling;

namespace V4_Laboration7.UI
{
    class Store
    {

        public static int SelectCategory()
        {

            Console.WriteLine("1. Artificial Organs");
            Console.WriteLine("2. Electronics");
            Console.WriteLine("3. Upload Knowledge");
            Console.WriteLine("4. Add Product to Registry");
            Console.WriteLine("5. View Shopping Cart");
            Console.WriteLine("6. Exit Program");

            return ValidateInput.Integer(Environment.NewLine + "Option: ");
        }

        public static void GetCommonProductProp(out string name, out string info, out int price, out bool isNew)
        {

            Console.Write("Product Name: ");
            name = Console.ReadLine();

            Console.Write("Product Information: ");
            info = Console.ReadLine();

            price = ValidateInput.Integer("Price: ");

            Console.Write("Is the product new (y/n)? ");
            isNew = Console.ReadLine().ToLower() == "y" ? true : false;
        }

        public static int GetProductType()
        {
            Console.WriteLine(Environment.NewLine + "This product is" + Environment.NewLine);

            Console.WriteLine("1. an Artificial Organ");
            Console.WriteLine("2. an Electronics item");
            Console.WriteLine("3. an Upload Knowledge Package");

            return ValidateInput.Integer(Environment.NewLine + "Product: ");
        }

        public static void ProductAddedValidation(string text)
        {
            Console.WriteLine(Environment.NewLine + "New product {0} added! Press enter to continue...", text);
            Console.ReadKey();
        }

        public static int PrintProductOptions(Product product)
        {

            Console.WriteLine("Selected Product | {0}", product.ProductParameterValues());
            Console.WriteLine(Environment.NewLine + "1. Add to Shopping Cart");
            Console.WriteLine("2. Remove from Inventory");

            return ValidateInput.Integer(Environment.NewLine + "Option: ");
        }

    }
}
