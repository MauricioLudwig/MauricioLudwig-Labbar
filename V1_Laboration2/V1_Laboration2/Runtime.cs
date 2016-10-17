using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1_Laboration2
{
    class Runtime
    {

        SpiderManager spiderManager = new SpiderManager();
        BearManager bearManager = new BearManager();
        SharkManager sharkManager = new SharkManager();

        public void Start()
        {

            int menuChoice;
            bool displayMainMenu = true;

            while (displayMainMenu == true)
            {
                Console.Clear();
                Menus.MainMenu();
                menuChoice = ValidateInput(1, 4);

                switch (menuChoice)
                {

                    // Add Animal
                    case 1:
                        Add();
                        break;
                    // Remove Animal
                    case 2:
                        Remove();
                        break;
                    // Show Animals
                    case 3:
                        Show();
                        break;
                    // Exit Program
                    case 4:
                        displayMainMenu = false;
                        Console.WriteLine(Environment.NewLine + "Goodbye!");
                        break;                            
                    default:
                        Console.WriteLine("This message should never print to console if the ValidateInput method works accordingly.");
                        break;
                }

            }
        }

        public void Add()
        {
            Console.Clear();
            Menus.AddMenu();
            int menuChoice = ValidateInput(1, 4);

            switch (menuChoice)
            {
                // Add Spider
                case 1:
                    spiderManager.AddSpider();
                    break;
                // Add Bear
                case 2:
                    bearManager.AddBear();
                    break;
                // Add Shark
                case 3:
                    sharkManager.AddShark();
                    break;
                // Go Back
                case 4:
                    break;
                default:
                    Console.WriteLine("This message should never print to console if the ValidateInput method works accordingly.");
                    break;
            }

            if (menuChoice != 4)
            {
                Console.Clear();
                TextColors.Green("Animal added!" + Environment.NewLine + Environment.NewLine);
                Console.WriteLine("Press enter to return to menu.");
                Console.ReadKey();
            }

        }

        public void Remove()
        {
            Console.Clear();
            Menus.RemoveMenu();
            int menuChoice = ValidateInput(1, 4);

            Console.Clear();
            TextColors.Red("Select animal to remove" + Environment.NewLine + Environment.NewLine);

            switch (menuChoice)
            {
                // Remove Spider
                case 1:
                    spiderManager.RemoveSpider();
                    break;
                // Remove Bear
                case 2:
                    bearManager.RemoveBear();
                    break;
                // Remove Shark
                case 3:
                    sharkManager.RemoveShark();
                    break;
                // Go Back
                case 4:
                    break;
                default:
                    Console.WriteLine("This message should never print to console if the ValidateInput method works accordingly.");
                    break;
            }

            if (menuChoice != 4)
            {
                Console.Clear();
                TextColors.Green("Animal removed!" + Environment.NewLine + Environment.NewLine);
                Console.WriteLine("Press enter to return to menu.");
                Console.ReadKey();
            }

        }

        public void Show()
        {
            Console.Clear();
            Menus.ShowMenu();
            int menuChoice = ValidateInput(1, 5);
            Console.Clear();

            switch (menuChoice)
            {
                // Show Spiders
                case 1:
                    spiderManager.ShowSpiders();
                    break;
                // Show Bears
                case 2:
                    bearManager.ShowBears();
                    break;
                // Show Sharks
                case 3:
                    sharkManager.ShowSharks();
                    break;
                // Show All
                case 4:
                    TextColors.White(Environment.NewLine + "Spiders ");
                    Console.WriteLine("-----------------------------------------------" + Environment.NewLine);
                    spiderManager.ShowSpiders();
                    TextColors.White("Bears ");
                    Console.WriteLine("-----------------------------------------------" + Environment.NewLine);
                    bearManager.ShowBears();
                    TextColors.White("Sharks ");
                    Console.WriteLine("-----------------------------------------------" + Environment.NewLine);
                    sharkManager.ShowSharks();
                    break;
                // Go Back
                case 5:
                    break;
                default:
                    Console.WriteLine("This message should never print to console if the ValidateInput method works accordingly.");
                    break;
            }

            if (menuChoice != 5)
            {
                Console.WriteLine("Press enter to return to menu.");
                Console.ReadKey();
            }
        }

        // Validate menu choice, specifically a valid integer input
        private static int ValidateInput(int minAllowedNumber, int maxAllowedNumber)
        {

            string input;
            bool validInput;
            bool continueLoop = true;
            int choice;

            do
            {
                Console.Write("Choice: ");
                input = Console.ReadLine();
                validInput = int.TryParse(input, out choice);

                if (validInput == true && choice >= minAllowedNumber && choice <= maxAllowedNumber)
                    continueLoop = false;
                else
                    TextColors.Red("Invalid input, try again." + Environment.NewLine);

            } while (choice < minAllowedNumber || choice > maxAllowedNumber && continueLoop == true);

            return choice;
        }

    }
}
