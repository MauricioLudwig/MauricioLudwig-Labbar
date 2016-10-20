using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2_Laboration4
{
    class ValidateInput
    {

        #region Integer (no parameters)
        public static int Integer()
        {
            bool validInput;
            string input;
            int output;

            do
            {
                TextColor.Yellow("Input: ");                
                input = Console.ReadLine();
                validInput = int.TryParse(input, out output);

                if (validInput)
                    return output;
                else
                    TextColor.Red("Invalid integer, try again.");

            } while (true);
        }
        #endregion

        #region Integer (minNum)
        public static int Integer(int minNum)
        {
            bool validInput;
            string input;
            int output;

            do
            {
                TextColor.Yellow("Input: ");
                input = Console.ReadLine();
                validInput = int.TryParse(input, out output);

                if (validInput && output >= minNum)
                    return output;
                else
                    TextColor.Red("Invalid integer, try again.");

            } while (true);
        }
        #endregion

        #region Integer (minNum and maxNum)
        public static int Integer(int minNum, int maxNum)
        {
            bool validInput;
            string input;
            int output;

            do
            {
                TextColor.Yellow("Input: ");
                input = Console.ReadLine();
                validInput = int.TryParse(input, out output);

                if (validInput && output >= minNum && output <= maxNum)
                    return output;
                else
                    TextColor.Red("Invalid integer, try again.");

            } while (true);
        }
        #endregion

    }
}
