using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4_Laboration7.ErrorHandling
{
    class ValidateInput
    {

        public static int Integer(string text)
        {

            string input;
            bool validInput;
            int output;

            do
            {

                Console.Write(text);
                input = Console.ReadLine();

                validInput = int.TryParse(input, out output);

                if (validInput)
                    return output;
                else
                    Console.WriteLine("Invalid input, try again.");

            } while (true);
        }
    }
}
