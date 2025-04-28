using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    internal class MinimumAndMaximum
    {
        public int FindMax(int[] array)
        {
            int max = array[0];
            foreach (int num in array)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }

        public int FindMin(int[] array)
        {
            int min = array[0];
            foreach (int num in array)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }

        public void Run()
        {
            Console.WriteLine("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int min = FindMin(arr);
            int max = FindMax(arr);

            Console.WriteLine($"Minimum number in the array: {min}");
            Console.WriteLine($"Maximum number in the array: {max}");
        }

        private static void Main(string[] args)
        {
            MinimumAndMaximum mm = new MinimumAndMaximum();
            mm.Run();
        }
    }
}