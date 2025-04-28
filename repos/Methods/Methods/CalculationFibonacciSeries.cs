using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class CalculationFibonacciSeries
    {
        private static int Fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        private static void Main(string[] args)
        {
            Console.Write("Enter the number of terms in the Fibonacci sequence: ");
            int terms = int.Parse(Console.ReadLine());

            Console.WriteLine($"The first {terms} of the Fibonacci sequence are: ");
            PrintFibonacci(terms, 0);
        }

        private static void PrintFibonacci(int terms, int current)
        {
            if (current < terms)
            {
                Console.Write($"{Fibonacci(current)} ");
                PrintFibonacci(terms, current + 1);
            }
        }
    }
}