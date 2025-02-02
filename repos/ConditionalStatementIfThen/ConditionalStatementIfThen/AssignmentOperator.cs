using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementIfThen
{
    internal class AssignmentOperator
    {
        static void Main(string[] args)
        {
            int c = 10;
            c += 5;
            Console.WriteLine(c);

            int x = 10, y = 10;
            if (x == y)
            {
                Console.WriteLine("Both Are Equal");
            }

            bool z = true;
            if (z = false)
            {
                Console.WriteLine("This will not be printed to the console.");
            }
            Console.WriteLine("The value of 'z' after the if statement: " + z);
        }
    }
}
