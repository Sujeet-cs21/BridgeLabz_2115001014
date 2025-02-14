using System;

namespace PP_14_02_25
{
    class MergeSort
    {
        static void MergeSorting(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                MergeSorting(arr, left, mid);
                MergeSorting(arr, mid + 1, right);

                Merge(arr, left, mid, right);
            }
        }
        public static void Merge(int[] ar, int low, int m, int high)
        {
            int[] temp = new int[ar.Length];

            for (int a = low; a <= high; a++)
            {
                temp[a] = ar[a];
            }

            int i = low, j = m + 1, k = low;
            while (i <= m && j <= high)
            {
                if (temp[i] <= temp[j])
                {
                    ar[k] = temp[i];
                    i++;
                }
                else
                {
                    ar[k] = temp[j];
                    j++;
                }
                k++;
            }

            while (i <= m)
            {
                ar[k] = temp[i];
                i++;
                k++;
            }
        }

        public static void Main3()
        {
            Console.Write("Enter number of Books : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter Prices");
            int[] prices = new int[n];

            for (int i = 0; i < n; i++)
            {
                prices[i] = Convert.ToInt32(Console.ReadLine());
            }
            MergeSorting(prices, 0, n - 1);

            Console.WriteLine($"Sorted Prices : {string.Join(" ",prices )}");
        }
    }
}
