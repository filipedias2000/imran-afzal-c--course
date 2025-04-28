using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Cylinder : AreaCalculator
    {
        protected double height;
        protected double volume;

        public void CalculateVolume()
        {
            volume = area * height;
        }

        public double GetHeight()
        {
            return height;
        }

        public double GetVolume()
        {
            return volume;
        }

        public void SetHeight(double h)
        {
            height = h;
        }
    }
}