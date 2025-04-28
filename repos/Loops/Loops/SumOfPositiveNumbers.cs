using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class SumOfPositiveNumbers
    {
        private static void Main(string[] args)
        {
            int x = 21;
            int sum = 0;
            do
            {
                sum += x;
                x--;
            } while (x > 10);
            Console.WriteLine("Summation: " + sum);
        }
    }
}