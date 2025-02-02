using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    internal class LadderIfElseExercise2
    {
        static void Main(string[] args)
        {
            String day = "Tuesday";
            if (day == "Monday")
            {
                Console.WriteLine("Monday Blues");
            }
            else if (day == "Tuesday")
            {
                Console.WriteLine("Tuesday Vibes");
            }
            else if (day == "Wednesday")
            {
                Console.WriteLine("Hump Day");
            }
            else if (day == "Thursday")
            {
                Console.WriteLine("Almost Friday");
            }
            else if (day == "Friday")
            {
                Console.WriteLine("TGIF");
            }
            else if (day == "Saturday")
            {
                Console.WriteLine("Weekend");
            }
            else if (day == "Sunday")
            {
                Console.WriteLine("Weekend Hangover");
            }
            else
            {
                Console.WriteLine("Invalid Day");
            }
            
        }
    }
}
