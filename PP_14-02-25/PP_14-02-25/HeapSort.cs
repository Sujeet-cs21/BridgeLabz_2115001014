using System;

namespace PP_14_02_25
{
    class HeapSort
    {
        static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
                largest = left;

            if (right < n && arr[right] > arr[largest])
                largest = right;

            if (largest != i)
            {
                (arr[i], arr[largest]) = (arr[largest], arr[i]);
                Heapify(arr, n, largest);
            }
        }

        static void HeapSorting(int[] arr)
        {
            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);

            for (int i = n - 1; i > 0; i--)
            {
                (arr[0], arr[i]) = (arr[i], arr[0]);
                Heapify(arr, i, 0);
            }
        }

        public static void Main6()
        {
            Console.Write("Enter number of applications : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter salaryDemanded ");
            int[] salaryDemands = new int[n];

            for (int i = 0; i < n; i++)
            {
                salaryDemands[i] = Convert.ToInt32(Console.ReadLine());
            }
            HeapSorting(salaryDemands);

            Console.WriteLine("Sorted Salaries: " + string.Join(" ", salaryDemands));
        }
    }

}
