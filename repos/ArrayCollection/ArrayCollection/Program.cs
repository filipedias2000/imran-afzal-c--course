using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers[2]);

            Console.WriteLine("1D Array Elements: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}