﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2_Laboration4
{
    class Runtime
    {
        ExternalVendor externalVendor = new ExternalVendor();

        public void Start()
        {

            VehicleManager vehicleMgr = new VehicleManager();
            Menus menu = new Menus();

            bool continueLoop = true;
            while (continueLoop)
            {

                Console.Clear();
                // FIX
                vehicleMgr.Overview();
                menu.MainMenu();
                switch (menu.Choice)
                {

                    #region 1. Car
                    case 1:
                        Console.Clear();
                        menu.VehicleMenu();
                        switch (menu.Choice)
                        {
                            case 1:
                                // 1.1 Add
                                Console.Clear();
                                vehicleMgr.AddCar();
                                break;
                            case 2:
                                // 1.2 Remove
                                Console.Clear();
                                vehicleMgr.RemoveCar();
                                Console.ReadKey(true);
                                break;
                            case 3:
                                // 1.3 Show Inventory
                                Console.Clear();
                                vehicleMgr.ShowCars();
                                Console.ReadKey(true);
                                break;
                            case 4:
                                // 1.4 Return
                                break;
                            default:
                                Console.WriteLine("Something went wrong.");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    #endregion

                    #region 2. Motorcycle
                    case 2:
                        Console.Clear();
                        menu.VehicleMenu();
                        switch (menu.Choice)
                        {
                            case 1:  
                                // 2.1 Add
                                Console.Clear();
                                vehicleMgr.AddMotorcycle();
                                break;
                            case 2:
                                // 2.2 Remove
                                Console.Clear();
                                vehicleMgr.RemoveMotorcycle();
                                Console.ReadKey(true);
                                break;
                            case 3:
                                // 2.3 Show Inventory
                                Console.Clear();
                                vehicleMgr.ShowMotorcycles();
                                Console.ReadKey(true);
                                break;
                            case 4:
                                // 2.4 Return
                                break;
                            default:
                                Console.WriteLine("Something went wrong.");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    #endregion

                    #region 3. Buy/Sell
                    case 3:
                        Console.Clear();
                        menu.BuyOrSellMenu();
                        if (menu.Choice == 1)
                            BuyVehicle();
                        else if (menu.Choice == 2)
                            vehicleMgr.SellVehicle();
                        break;
                    #endregion

                    #region 4. Exit Program
                    case 4:
                        continueLoop = false;
                        break;
                    #endregion

                    #region Default
                    default:
                        Console.WriteLine("Something went wrong.");
                        Console.ReadKey();
                        break;
                    #endregion
                }
            }
        }

        public void BuyVehicle()
        {

            Console.Clear();
            foreach (var carForSale in externalVendor.VendorsVehicles)
            {
                Console.Write(carForSale.VehicleDescription());
                Console.WriteLine("\tCategory: {0}", carForSale.Category);
            }

            //do
            //{
            //    Console.WriteLine("Filter by: ");
            //    Console.WriteLine("1. Manufacturer\t2. Model\t3.Color\t4. Car\t5. Motorcycle");
            //} while (true);

            Console.ReadKey();
        }


    } // Class
} // Namespace
