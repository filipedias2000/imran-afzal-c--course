using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    internal class ArrayListAndLinkedList
    {
        private static void Main(string[] args)
        {
            List<int> arrayList = new List<int>();
            LinkedList<int> linkedList = new LinkedList<int>();

            for (int i = 0; i < 1000000; i++)
            {
                arrayList.Add(i);
                linkedList.AddLast(i);
            }

            long startTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            int elementAL = arrayList[500000];
            long endTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            long durationAL = endTime - startTime;

            startTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            int elementLL = linkedList.ElementAt(500000);
            endTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            long durationLL = endTime - startTime;

            Console.WriteLine("Element retrieved from List: " + elementAL);
            Console.WriteLine("Element retrieved from LinkedList: " + elementLL);
            Console.WriteLine("Time taken by List: " + durationAL + " milliseconds");
            Console.WriteLine("Time taken by LinkedList: " + durationLL + " milliseconds");
        }
    }
}