using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using V4_Laboration7.ErrorHandling;

namespace V4_Laboration7.UI
{
    class Store
    {

        public static int SelectCategory()
        {

            Console.WriteLine("1. Artificial Organs");
            Console.WriteLine("2. Electronics");
            Console.WriteLine("3. Upload Knowledge");
            Console.WriteLine("4. Exit Program");

            return ValidateInput.Integer("Category: ");
        }
    }
}
