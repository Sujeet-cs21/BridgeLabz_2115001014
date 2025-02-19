using System;
using System.Collections.Generic;

namespace PP_19_02_25
{
    class BinaryNumbers
    {
        static void GenerateBinaryNumbers(int N)
        {
            Queue<string> queue = new Queue<string>();

            // Start with the first binary number
            queue.Enqueue("1");

            // Generate binary numbers
            for (int i = 0; i < N; i++)
            {
                // Dequeue the front element
                string current = queue.Dequeue();
                Console.Write(current + " ");

                // enqueue "0" and "1" to current binary number
                queue.Enqueue(current + "0");
                queue.Enqueue(current + "1");
            }
        }

        public static void Main12()
        {
            int N = 5;

            Console.WriteLine("First " + N + " binary numbers: ");
            GenerateBinaryNumbers(N);
        }
    }

}
