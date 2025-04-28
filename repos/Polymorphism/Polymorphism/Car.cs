using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Car
    {
        public Car(string model, int year)
        {
            Model = model;
            Year = year;
        }

        public string Model { get; set; }
        public int Year { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Model: {Model}, Year: {Year}");
        }

        public void OperateVehicle(int speed)
        {
            StartEngine();
            Accelerate(speed);
        }

        protected virtual void Accelerate(int speed)
        {
            Console.WriteLine($"Accelerating at {speed} mph");
        }

        protected virtual void StartEngine()
        {
            Console.WriteLine("Engine started!");
        }
    }
}