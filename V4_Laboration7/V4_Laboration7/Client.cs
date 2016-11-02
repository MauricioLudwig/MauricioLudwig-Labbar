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
                        storeController.SetCategory(1);
                        storeController.PrintProducts();
                        break;
                    case 2:
                        storeController.SetCategory(2);
                        storeController.PrintProducts();
                        break;
                    case 3:
                        storeController.SetCategory(3);
                        storeController.PrintProducts();
                        break;
                    case 4:
                        loop = false;
                        break;
                }

            } while (loop); 
        }
    }
}
