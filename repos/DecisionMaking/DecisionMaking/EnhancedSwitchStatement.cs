using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    internal class EnhancedSwitchStatement
    {
        private static void Main(string[] args)
        {
            int number = 3;
            string result = number switch
            {
                1 => "One",
                2 => "Two",
                3 => "Three",
                _ => "Other"
            };
            Console.WriteLine(result);
        }
    }
}