using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1_Laboration2
{
    class Runtime
    {

        public void Start()
        {

            int menuChoice;
            bool displayMainMenu = true;

            while (displayMainMenu == true)
            {

                Menus.MainMenu();
                menuChoice = ValidateInput(1, 4);

                switch (menuChoice)
                {

                    // 1. Arthropod
                    case 1:
                        break;
                    // 2. Fish
                    case 2:
                        break;
                    // 3. Mammal
                    case 3:
                        break;
                    // 4. Exit
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
