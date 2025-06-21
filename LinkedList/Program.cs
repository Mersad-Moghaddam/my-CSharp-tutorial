using System;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Collections
{
    class Program
    {
        static void Main()
        {
            List<int> arrayList = new List<int>();
            LinkedList<int> linkedList = new LinkedList<int>();

            for (int i = 0; i < 1000000; i++)
            {
                arrayList.Add(i);
                linkedList.AddLast(i);
            }

            long startTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            int elementAL = arrayList[900000];
            long endTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            long durationAL = endTime - startTime;



            startTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            int elementLL = linkedList.ElementAt(900000);
            endTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            long durationLL = endTime - startTime;



            Console.WriteLine($"Element retrieved from List : {elementAL}");
            Console.WriteLine($"Element retrieved from Linked List : {elementLL}");
           Console.WriteLine($"Time taken by List : {durationAL} Millisecond");
          Console.WriteLine($"Time taken by Linked List : {durationLL} Millisecond");

        }
    }
}