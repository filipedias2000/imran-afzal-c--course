using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementIfThen
{
    internal class LogicalOperators
    {
        static void Main(string[] args)
        {
            int age = 20;
            //if (age > 18)
            //{
            //    Console.WriteLine("Condition is True");
            //}
            String gender = "male";
            //if (gender == "male")
            //{
            //    Console.WriteLine("Condition is True");
            //}
            if (age > 18 && gender == "male")
            {
                Console.WriteLine("Eligible");
            }
            
        }
    }
}
