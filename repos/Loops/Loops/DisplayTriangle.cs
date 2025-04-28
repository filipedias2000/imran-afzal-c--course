using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class DisplayTriangle
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter the number of rows for the triangle: ");
            int numberOfRows = int.Parse(Console.ReadLine());

            Console.WriteLine("\nRight-Angle Triangle:");

            for (int i = 1; i <= numberOfRows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}