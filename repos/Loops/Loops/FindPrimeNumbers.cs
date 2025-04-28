using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class FindPrimeNumbers
    {
        public static bool isPrime(int wholeNumber)
        {
            if (wholeNumber <= 2)
            {
                return (wholeNumber == 2);
            }

            for (int divisor = 2; divisor <= wholeNumber / 2; divisor++)
            {
                if (wholeNumber % divisor == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static void Main(string[] args)
        {
            Console.Write("Enter a number to check, it's a prime or not: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number + " is " + (isPrime(number) ? "" : "not ") + "a prime number.");
        }
    }
}