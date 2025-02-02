using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    internal class LadderIfElseExercise
    {
        static void Main(string[] args)
        {
            int age = 30;
            if(age < 18)
            {
                Console.WriteLine("Child");
            }
            else if(age >= 18 && age <= 20)
            {
                Console.WriteLine("Teenager");
            }
            else if(age >= 21 && age <= 65)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Senior Citizen");
            }
        }
    }
}
