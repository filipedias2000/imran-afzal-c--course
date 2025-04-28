using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Shapes
    {
        public static double area(double length, double width)
        {
            return length * width;
        }

        public static double area(int side)
        {
            return side * side;
        }

        public static double area(double base1, double height, double shape)
        {
            return 0.5 * base1 * height;
        }

        public static double area(double radius)
        {
            return 3.14 * radius * radius;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Area of rectangle: " + area(30.0, 20.0));
            Console.WriteLine("Area of square: " + area(30));
            Console.WriteLine("Area of triangle: " +
                area(50.0, 10.0, 0.5));
            Console.WriteLine("Area of circle: " + area(40.0));
        }
    }
}