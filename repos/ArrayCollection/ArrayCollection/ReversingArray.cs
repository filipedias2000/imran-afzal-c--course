using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    internal class ReversingArray
    {
        private int[] originalArray;

        public void Run()
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            originalArray = new int[size];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                originalArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nOriginal Array:");
            PrintArray(originalArray);

            ReverseArray();

            Console.WriteLine("\nReversed Array");
            PrintArray(originalArray);
        }

        private static void Main(string[] args)
        {
            ReversingArray ra = new ReversingArray();
            ra.Run();
        }

        private void PrintArray(int[] arr)
        {
            foreach (var element in arr)
            {
                Console.WriteLine(element + " ");
            }
            Console.WriteLine();
        }

        private void ReverseArray()
        {
            int start = 0;
            int end = originalArray.Length - 1;

            while (start < end)
            {
                int temp = originalArray[start];
                originalArray[start] = originalArray[end];
                originalArray[end] = temp;

                start++;
                end--;
            }
        }
    }
}