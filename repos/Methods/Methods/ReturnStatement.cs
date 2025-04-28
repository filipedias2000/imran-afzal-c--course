using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class ReturnStatement
    {
        public static double calculateArea(double radius, double pi)
        {
            double result = radius * pi;
            //Console.WriteLine("Area of circle is: " + result);
            return result;
        }

        private static void Main(string[] args)
        {
            double areaCircle = calculateArea(10.5, 3.14);
            Console.WriteLine("Area of circle is: " + areaCircle);
        }
    }
}