using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class ForLoopExampleTwo
    {
        private static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                else if (i == 8)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}