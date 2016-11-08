using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V5_Laboration8
{
    class Runtime
    {

        public delegate string StringConcatinator(string[] names);
        public delegate double PriceOperator(double[] prices);
        public Lists MyLists { get; set; }

        #region String Concatinator
        public string Concatinator(string[] strings)
        {
            string result = String.Empty;
            int index = 0;

            foreach (var mString in strings)
            {
                index++;
                if (index < strings.Length)
                {
                    result += mString + ", ";
                }
                else
                    result += mString;
            }

            return result;
        }
        #endregion

        #region G - Assignment
        public void Assignment1()
        {

            MyLists = new Lists();

            StringConcatinator stringCon1 = Concatinator;
            Console.WriteLine(Environment.NewLine + "Concatination: " + stringCon1(MyLists.MyStrings));

            Func<float[], float> floatAddition = (myFloats) =>
            {
                float result = 0;

                foreach (var number in myFloats)
                {
                    result += number;
                }

                return result;
            };

            Func<float[], float> floatMultiply = (myFloats) =>
            {
                float result = 1;

                foreach (var number in myFloats)
                {
                    result *= number;
                }

                return result;
            };

            Console.Write("Addition: ");
            Calculator(floatAddition);

            Console.Write("Multiplication: ");
            Calculator(floatMultiply);

            Console.ReadKey();
        }
        #endregion

        #region Calculator
        public void Calculator(Func<float[], float> calcFunc)
        {
            float result = calcFunc(MyLists.MyFloats);
            Console.WriteLine(result);
        }
        #endregion

        #region VG - Assignment
        public void Assignment2()
        {

            ProductManager productManager = new ProductManager();

            string[] productNames = productManager.Items
                .Select(item => item.Name)
                .ToArray();

            double[] productPrices = productManager.Items
                .Select(item => item.Price)
                .ToArray();

            Console.Write(Environment.NewLine + "Concatination: ");
            StringConcatinator stringCon2 = productManager.FormatProductNames;
            Console.WriteLine(stringCon2(productNames));

            Console.Write("Adjusted total sum: ");
            PriceOperator PriceCalculator = productManager.PriceCalculation;
            Console.WriteLine(PriceCalculator(productPrices));

            Console.ReadKey();
        }
        #endregion

    }
}

