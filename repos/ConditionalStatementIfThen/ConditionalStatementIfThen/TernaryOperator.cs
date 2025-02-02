using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementIfThen
{
    internal class TernaryOperator
    {
        static void Main(string[] args)
        {
            int age = 20;
            String status;
            status = (age < 18) ? "Under Age" : "Senior";
            Console.WriteLine(status);

        }
    }
}
