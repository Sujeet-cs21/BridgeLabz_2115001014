using System;
namespace PP_14_02_25
{
    class SelectionSort
    {
        static void SelectionSorting(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
            }
        }

        public static void Main5()
        {
            Console.Write("Enter number of Students : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter Scores :");
            int[] examScores = new int[n];

            for (int i = 0; i < n; i++)
            {
                examScores[i] = Convert.ToInt32(Console.ReadLine());
            }
            SelectionSorting(examScores);

            Console.WriteLine("Sorted Scores: " + string.Join(" ", examScores));
        }
    }
}
