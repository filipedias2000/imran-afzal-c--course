using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementIfThen
{
    internal class OrOperator
    {
        static void Main(string[] args)
        {
            double examScore = 85;
            if(examScore >= 60 || examScore <= 100)
            {
                Console.WriteLine("The student has passed the exam");
            }

            double num = 6;
            if(num % 2 == 0 || num % 3 == 0)
            {
                Console.WriteLine("The Number is even or divisible by 3");
            }

            int num1 = 7;
            if(!(num1 % 2 == 0))
            {
                Console.WriteLine("The Number is odd");
            }

        }
    }
}
