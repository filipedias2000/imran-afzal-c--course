using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    internal class Dictionaries
    {
        private static void Main(string[] args)
        {
            Dictionary<string, int> ageDictionary = new Dictionary<string, int>();

            ageDictionary["John"] = 25;
            ageDictionary["Alice"] = 30;
            ageDictionary["Bob"] = 22;

            Console.WriteLine("John's age: " + ageDictionary["John"]);
            Console.WriteLine("Alice's age: " + ageDictionary["Alice"]);
            Console.WriteLine("Bob's age: " + ageDictionary["Bob"]);

            string searchName = "Alice";

            if (ageDictionary.ContainsKey(searchName))
            {
                Console.WriteLine($"{searchName} exists in the dictionary " +
                    $"with age {ageDictionary[searchName]}.");
            }
            else
            {
                Console.WriteLine($"{searchName} does not exist in the dictionary.");
            }
        }
    }
}