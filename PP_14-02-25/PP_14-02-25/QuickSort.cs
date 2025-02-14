using System;

namespace PP_14_02_25
{
    class QuickSort
    {
        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }

            (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
            return i + 1;
        }

        static void QuickSorting(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);

                QuickSorting(arr, low, pi - 1);
                QuickSorting(arr, pi + 1, high);
            }
        }

        public static void Main4()
        {
            Console.Write("Enter number of product : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter Prices");
            int[] prices = new int[n];

            for (int i = 0; i < n; i++)
            {
                prices[i] = Convert.ToInt32(Console.ReadLine());
            }

            QuickSorting(prices, 0, n-1);

            Console.WriteLine("Sorted Prices: " + string.Join(" ", prices));
        }
    }
}
