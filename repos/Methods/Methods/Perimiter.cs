using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Perimiter
    {
        public static int AreaRectangle(int length, int width)
        {
            return length * width;
        }

        public static int AreaSquare(int side)
        {
            return side * side;
        }

        public static int PerimeterRectangle(int length, int width)
        {
            return 2 * (length + width);
        }

        public static int PerimeterSquare(int side)
        {
            return 4 * side;
        }

        private static void Main(string[] args)
        {
            Console.Write("Enter the length of the rectangle: ");
            int rectangleLength = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle: ");
            int rectangleWidth = int.Parse(Console.ReadLine());

            Console.Write("Enter the side length of the square: ");
            int squareSide = int.Parse(Console.ReadLine());

            Console.WriteLine("Perimeter of Rectangle: " + PerimeterRectangle(rectangleLength,
                rectangleWidth));
            Console.WriteLine("Area of Rectangle: " + AreaRectangle(rectangleLength,
                rectangleWidth));
            Console.WriteLine("Perimeter of Square: " + PerimeterSquare(squareSide));
            Console.WriteLine("Area of Square: " + AreaSquare(squareSide));
        }
    }
}