using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2_Laboration4
{
    class Runtime
    {
        VehicleManager vehicleMgr = new VehicleManager();
        MenuManager menuMgr = new MenuManager();

        public void Start()
        {

            bool continueMainMenu = true;

            while (continueMainMenu)
            {
                menuMgr.MainMenu();

                switch (menuMgr.menuOption)
                {
                    #region Add Vehicle
                    case 1:
                        do
                        {
                            menuMgr.AddVehicleMenu();
                            if (menuMgr.menuOption == 1)
                                vehicleMgr.AddCar();
                            else if (menuMgr.menuOption == 2)
                                vehicleMgr.AddMotorcycle();
                        } while (menuMgr.menuOption != 3);
                        break;
                    #endregion
                    
                    #region Remove Vehicle
                    case 2:
                        vehicleMgr.RemoveVehicle();
                        break;
                    #endregion

                    #region Buy Vehicle
                    case 3:
                        do
                        {
                            menuMgr.BuyVehicleMenu();
                            if (menuMgr.menuOption == 1)
                                vehicleMgr.BuyNewVehicle();
                            else if (menuMgr.menuOption == 2)
                                vehicleMgr.BuyOldVehicle();
                        } while (menuMgr.menuOption != 3);
                        break;
                    #endregion

                    #region Sell Vehicle
                    case 4:
                        vehicleMgr.SellVehicle();
                        break;
                    #endregion

                    #region View Inventory
                    case 5:
                        vehicleMgr.ViewInventory();
                        break;
                    #endregion

                    case 6:
                        continueMainMenu = false;
                        break;

                    default:
                        break;
                }
            }
        }

    }
}
