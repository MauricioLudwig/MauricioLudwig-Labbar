using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V6_Laboration11
{

    class Runtime
    {

        public delegate void AnalyzeNumber(int number);
        public event AnalyzeNumber NumberInput;

        public void Start()
        {
            Console.Write("Input a number: ");
            int input = int.Parse(Console.ReadLine());

            NumberInput += new AnalyzeNumber(IsEven);
            NumberInput += new AnalyzeNumber(IsDivisibleByThree);
            NumberInput += new AnalyzeNumber(IsPrimeNumber);

            OnNumberInput(input);
        }

        private void OnNumberInput(int input)
        {
            NumberInput?.Invoke(input);
        }

        public void IsEven(int number)
        {
            Console.WriteLine("{0} is {1} even number.", number, number % 2 == 0 ? "an" : "not an");
        }

        public void IsDivisibleByThree(int number)
        {
            Console.WriteLine("{0} {1} divisible by three.", number, number % 3 == 0 ? "is" : "is not");
        }

        public void IsPrimeNumber(int number)
        {
            bool isPrime = true;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine("{0} {1} a prime number.", number, isPrime == true ? "is" : "is not");
        }

    }
}
