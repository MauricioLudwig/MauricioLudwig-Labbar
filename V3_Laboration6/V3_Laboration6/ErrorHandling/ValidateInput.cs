using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V3_Laboration6.Esthetics;

namespace V3_Laboration6.ErrorHandling
{
    class ValidateInput
    {
        public static int Integer(string text)
        {

            bool validInput;
            string input;
            int output;

            do
            {
                TextColor.Yellow(text);
                input = Console.ReadLine();
                validInput = int.TryParse(input, out output);

                if (validInput)
                    return output;
                else
                    TextColor.Red("Only digits allowed. Try again." + Environment.NewLine);

            } while (true);
        }

        public static int Integer(int minNum, int maxNum, string text)
        {

            bool validInput;
            string input;
            int output;

            do
            {
                TextColor.Yellow(text);
                input = Console.ReadLine();
                validInput = int.TryParse(input, out output);

                if (validInput && output >= minNum && output <= maxNum)
                    return output;
                else
                    TextColor.Red("Invalid input. Try again." + Environment.NewLine);

            } while (true);
        }

    }
}