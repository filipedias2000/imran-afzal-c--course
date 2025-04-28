using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class DoWhileLoop
    {
        private static void Main(string[] args)
        {
            int i = 6;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 5);
        }
    }
}