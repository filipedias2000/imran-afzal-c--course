using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class TemperatureConverter
    {
        public static double CalculateTemperature(char tempChar, double temperature)
        {
            double result;
            if (tempChar == 'F')
            {
                result = (temperature - 32) * 5 / 9;
            }
            else if (tempChar == 'C')
            {
                result = (temperature * 9 / 5) + 32;
            }
            else
            {
                result = 0;
            }
            return result;
        }

        public static void PrintResult(char tempName, double result)
        {
            Console.WriteLine($"Temperature is: {result} {tempName}");
        }

        private static void Main(string[] args)
        {
            Console.Write("Enter the temperature scale (F or C): ");
            char tempName = char.Parse(Console.ReadLine());

            Console.Write("Enter the temperature value: ");
            double tempValue = double.Parse(Console.ReadLine());

            double calculatedResult = CalculateTemperature(tempName, tempValue);
            PrintResult(tempName, calculatedResult);
        }
    }
}