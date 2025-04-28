using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class MethodOverloading
    {
        public static void add()
        {
            Console.WriteLine("Method with no parameter");
        }

        public static void add(int a, int b)
        {
            Console.WriteLine("Method with Two Parameters: "
                + a + " & " + b);
        }

        public static void add(int a, int b, int c)
        {
            Console.WriteLine("Method with Three Parameters: "
                + a + " " + b + " & " + c);
        }

        private static void Main(string[] args)
        {
            add();
            add(10, 20);
            add(100, 200, 400);
        }
    }
}