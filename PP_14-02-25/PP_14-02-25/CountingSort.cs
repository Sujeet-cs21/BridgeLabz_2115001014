using System;

namespace PP_14_02_25
{
    class CountingSort
    {
        static void CountingSortAlgo(int[] arr, int maxAge)
        {
            int[] count = new int[maxAge + 1];
            int[] output = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
                count[arr[i]]++;

            for (int i = 1; i <= maxAge; i++)
                count[i] += count[i - 1];

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                output[count[arr[i]] - 1] = arr[i];
                count[arr[i]]--;
            }

            for (int i = 0; i < arr.Length; i++)
                arr[i] = output[i];
        }

        public static void Main7()
        {
            Console.Write("Enter number of Students : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter Age from 10 to 18 :");
            int[] ages = new int[n];

            for (int i = 0; i < n; i++)
            {
                ages[i] = Convert.ToInt32(Console.ReadLine());
            }

            CountingSortAlgo(ages, 18);

            Console.WriteLine("Sorted Ages: " + string.Join(" ", ages));
        }
    }

}
