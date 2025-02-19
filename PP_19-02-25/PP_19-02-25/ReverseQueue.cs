using System;
using System.Collections.Generic;

namespace PP_19_02_25
{
    class ReverseQueue
    {
        // Function to reverse a queue
        static void FindReverseQueue(Queue<int> queue)
        {
            int size = queue.Count;

            //temporary list to store elements of the queue
            List<int> tempList = new List<int>();

            for (int i = 0; i < size; i++)
            {
                tempList.Add(queue.Dequeue());
            }

            // Enqueue the elements back in reverse order
            for (int i = tempList.Count - 1; i >= 0; i--)
            {
                queue.Enqueue(tempList[i]);
            }
        }

        public static void Main11()
        {
            // Create a queue with some elements
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine("Original Queue: ");
            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }

            // Reverse the queue
            FindReverseQueue(queue);

            Console.WriteLine("\nReversed Queue: ");
            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }
        }
    }
}
