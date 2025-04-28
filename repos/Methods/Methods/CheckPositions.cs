using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class CheckPositions
    {
        public static int PositionMethod(int number)
        {
            if (number < 50)
            {
                return 0;
            }
            else if (number >= 50 && number <= 60)
            {
                return 5;
            }
            else if (number >= 61 && number <= 70)
            {
                return 4;
            }
            else if (number >= 71 && number <= 80)
            {
                return 3;
            }
            else if (number >= 81 && number <= 90)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        public static void printPosition(string stdName, int position)
        {
            Console.WriteLine("Student Name is: " + stdName + " & Position is: " + position);
        }

        private static void Main(string[] args)
        {
            Console.Write("Enter the name for the first student: ");
            string studentName = Console.ReadLine();
            Console.Write("Enter the score for " + studentName + ": ");
            int studentNumbers = int.Parse(Console.ReadLine());
            int studentPosition = PositionMethod(studentNumbers);
            printPosition(studentName, studentPosition);
        }
    }
}