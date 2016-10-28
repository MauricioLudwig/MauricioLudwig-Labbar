using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V3_Laboration5.Esthetics;

namespace V3_Laboration5.ErrorHandling
{
    class ValidateInput
    {

        public static int Integer(string inputText)
        {
            int output;
            bool validInput;
            string input;

            do
            {

                Console.Write(inputText);
                input = Console.ReadLine();
                validInput = int.TryParse(input, out output);

                if (validInput)
                    return output;
                else
                    TextAndColor.Red("Invalid input. Try again." + Environment.NewLine);

            } while (true);
        }

        public static int Integer(int minNum, int maxNum, string inputText)
        {
            int output;
            bool validInput;
            string input;

            do
            {

                Console.Write(inputText);
                input = Console.ReadLine();
                validInput = int.TryParse(input, out output);

                if (validInput && output <= maxNum && output >= minNum)
                    return output;
                else
                    TextAndColor.Red("Invalid input. Try again." + Environment.NewLine);

            } while (true);
        }

    }
}
