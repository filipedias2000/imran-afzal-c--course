using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    internal class LadderIfElse
    {
        static void Main(string[] args)
        {
            int marks = 65;
            if (marks >= 90)
            {
                Console.WriteLine("Excellent");
            }
            else if(marks >= 70 && marks <= 89)
            {
                Console.WriteLine("Good");
            }
            else if(marks >= 50 && marks <= 69)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Poor"); 
            }

        }
    }
}
