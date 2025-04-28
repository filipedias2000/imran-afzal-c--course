using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class ElectricCar : Car
    {
        public ElectricCar(string model, int year) : base(model, year)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Eletric Car -  Model: {Model}, Year: {Year}");
        }

        protected override void Accelerate(int speed)
        {
            Console.WriteLine($"Accelerating silently at {speed} mph");
        }

        protected override void StartEngine()
        {
            Console.WriteLine("Starting eletric motor!");
        }
    }
}