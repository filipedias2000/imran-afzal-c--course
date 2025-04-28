using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    internal class EnhancedSwitch2
    {
        private static void Main(string[] args)
        {
            String shape = "Trapezoid";
            // Ellipse
            double majorAxis = 11;
            double minorAxis = 16;
            // Trapezoid
            double topBase = 0;
            double bottomBase = 0;
            double height = 0;
            // Parallelogram
            double base1 = 11;
            double heightPara = 14;
            double areaResult;

            areaResult = shape switch
            {
                "Ellipse" => (3.14 * majorAxis * minorAxis),
                "Trapezoid" => (((topBase + bottomBase) / 2) * height),
                "Parallelogram" => (base1 * heightPara),
                _ => 0
            };
            Console.WriteLine(shape + " : " + areaResult);
        }
    }
}