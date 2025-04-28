using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class LeapYear
    {
        public static void CheckLeapYear(int year)
        {
            if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
            {
                Console.WriteLine(year + " is a leap year");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year");
            }
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a year to check its leap year or not: ");
            int checkYear = int.Parse(Console.ReadLine());
            CheckLeapYear(checkYear);
        }
    }
}