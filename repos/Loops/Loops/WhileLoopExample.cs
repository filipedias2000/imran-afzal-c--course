using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class WhileLoopExample
    {
        public static void checkEvenOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine(num + " is even");
            }
            else
            {
                Console.WriteLine(num + " is odd");
            }
        }

        private static void Main(string[] args)
        {
            int start = 5;
            int end = 11;
            while (start <= end)
            {
                checkEvenOdd(start);
                start++;
            }
        }
    }
}