using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V4_Laboration7.StoreManager;

namespace V4_Laboration7
{
    class Client
    {

        public void Start()
        {

            StoreController storeController = new StoreController();
            bool loop = true;

            do
            {

                Console.Clear();
                int category = UI.Store.SelectCategory();

                switch (category)
                {
                    case 1:
                    case 2:
                    case 3:
                        storeController.PrintProducts(category);
                        break;
                    case 4:
                        storeController.AddProduct();
                        break;
                    case 5:
                        Customer.PrintShoppingCart();
                        break;
                    case 6:
                        loop = false;
                        break;
                }

            } while (loop); 
        }
    }
}
