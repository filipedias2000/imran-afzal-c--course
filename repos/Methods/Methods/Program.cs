using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        public static void Modifiers(int number, String name)
        {
            Console.WriteLine("First Parameter Value is: " + number);
            Console.WriteLine("Second Parameter Value is: " + name);
        }

        public static void printString()
        {
            Console.WriteLine("Hello World");
        }

        private static void Main(string[] args)
        {
            printString();

            Modifiers(1, "Nixware");
        }
    }
}