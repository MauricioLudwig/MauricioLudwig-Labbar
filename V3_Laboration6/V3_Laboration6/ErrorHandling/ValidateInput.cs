using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                Console.Write(text);
                input = Console.ReadLine();
                validInput = int.TryParse(input, out output);

                if (validInput)
                    return output;
                else
                    Console.WriteLine("Input is not a string. Try again.");

            } while (true);
        }
    }
}
