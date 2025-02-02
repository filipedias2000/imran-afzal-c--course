using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    internal class NestedIfElse
    {
        static void Main(string[] args)
        {
            int number = 5;
            if (number > 0 )
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("Number is Positive and Even");
                }
                else
                {
                    Console.WriteLine("Number is Positive but not Even");
                }
            }
            else
            {
                Console.WriteLine("Number is not Positive");
            }

        }
    }
}
