using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementIfThen
{
    internal class ComparisonOperators
    {
        static void Main(string[] args)
        {
            int x = 5, y = 3, z = 4;
            if(x > y && x > z)
            {
                Console.WriteLine("x is the largest number");
            }

            int score = 85;
            String grade;
            if (score >= 80 && score <= 95)
            {
                grade = "A";
                Console.WriteLine(grade);
            }
        }
    }
}
