using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2_Laboration3
{
    class ValidateInput
    {

        public static int ValidateInteger(int minNumber, int maxNumber)
        {
            int input;
            bool validInput;

            do
            {
                TextColor.Yellow(Environment.NewLine + "Choice: ");
                validInput = int.TryParse(Console.ReadLine(), out input);

                if (validInput && input >= minNumber && input <= maxNumber)
                    return input;
                else
                    TextColor.Red("Invalid input, try again.");

            } while (true);
        }
    }
}
