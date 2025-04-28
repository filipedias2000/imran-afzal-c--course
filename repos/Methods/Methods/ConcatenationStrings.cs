using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class ConcatenationStrings
    {
        public static String Concatenate(String s1, String s2)
        {
            return s1 + s2;
        }

        public static String Concatenate(String s1,
            String s2, String separator)
        {
            return s1 + separator + s2;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Concatenation without Separator: " +
                Concatenate("Nixware", "Company"));
            Console.WriteLine("Concatenation with Separator: " +
                Concatenate("Nixware", "Company", "--"));
        }
    }
}