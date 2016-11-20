using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V6_Laboration16.GUI;
using V6_Laboration16.Repositories;
using V6_Laboration16.Controllers;

namespace V6_Laboration16
{
    class Client
    {

        public ProductController productController { get; set; }

        public void Start()
        {

            productController = new ProductController();

            bool loop = true;

            while (loop)
            {
                Console.Clear();
                Menus.Start();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        UsingListRepository();
                        break;
                    case ConsoleKey.D2:
                        UsingFileRepository();
                        break;
                    case ConsoleKey.D3:
                        loop = false;
                        Console.WriteLine("Bye!");
                        break;
                }
            }
        }

        public void UsingListRepository()
        {

            bool loop = true;

            while (loop)
            {

                Console.Clear();
                Menus.Product();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        productController.Add_List();
                        break;
                    case ConsoleKey.D2:
                        productController.GetSingle_List();
                        break;
                    case ConsoleKey.D3:
                        productController.GetAll_List();
                        break;
                    case ConsoleKey.D4:
                        productController.Update_List();
                        break;
                    case ConsoleKey.D5:
                        productController.Delete_List();
                        break;
                    case ConsoleKey.D6:
                        loop = false;
                        break;
                }
            }
        }

        public void UsingFileRepository()
        {

            bool loop = true;

            while (loop)
            {

                Console.Clear();
                Menus.Product();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        productController.Add_File();
                        break;
                    case ConsoleKey.D2:
                        productController.GetSingle_File();
                        break;
                    case ConsoleKey.D3:
                        productController.GetAll_File();
                        break;
                    case ConsoleKey.D4:
                        productController.Update_File();
                        break;
                    case ConsoleKey.D5:
                        productController.Delete_File();
                        break;
                    case ConsoleKey.D6:
                        loop = false;
                        break;
                }
            }
        }
    }
}
