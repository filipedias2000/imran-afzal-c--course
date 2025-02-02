using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    internal class SwitchStatement
    {
        static void Main(string[] args)
        {
            int day = 3;
            if (day == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (day == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (day == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else
            {
                Console.WriteLine("Invalid day");
            }
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }
        }
    }
}
