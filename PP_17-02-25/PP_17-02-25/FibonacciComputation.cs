using System;
using System.Diagnostics;

namespace PP_17_02_25
{
    class FibonacciComputation
    {
        public static void Main5()
        {
            int[] Ns = { 10, 30, 50 };

            foreach (int n in Ns)
            {
                // Fibonacci Iterative
                Stopwatch sw = Stopwatch.StartNew();
                FibonacciIterative(n);
                sw.Stop();
                Console.WriteLine($"Fibonacci Iterative N={n}: {sw.Elapsed.TotalMilliseconds}ms");

                // Fibonacci Recursive
                sw.Restart();
                FibonacciRecursive(n);
                sw.Stop();
                Console.WriteLine($"Fibonacci Recursive N={n}: {sw.Elapsed.TotalMilliseconds}ms");
                Console.WriteLine();
            }
        }

        //Fibonacci Recursive
        public static int FibonacciRecursive(int n)
        {
            if(n>30)
            {
                Console.WriteLine("Fibonacci Recursive is not feasible for large series");
                return -1;
            }
            if (n <= 1) return n;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        //Fibonacci Iterative
        public static int FibonacciIterative(int n)
        {
            int a = 0, b = 1, sum;
            for (int i = 2; i <= n; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
            }
            return b;
        }

    }
}
