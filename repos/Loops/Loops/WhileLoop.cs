using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class WhileLoop
    {
        private static void Main(string[] args)
        {
            int number = 10;
            while (true)
            {
                if (number < 1)
                {
                    break;
                }
                Console.WriteLine(number);
                number--;
            }
        }
    }
}