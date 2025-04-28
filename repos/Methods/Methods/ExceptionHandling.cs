using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class ExceptionHandling
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter numerator value: ");
            int numerator = int.Parse(Console.ReadLine());

            Console.Write("Enter denominator value: ");
            int denominator = int.Parse(Console.ReadLine());

            try
            {
                int result = numerator / denominator;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error. The denominator must be greater than zero");
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }
            Console.WriteLine("Program continues executing after the " + "try-catch-finally block");
        }
    }
}