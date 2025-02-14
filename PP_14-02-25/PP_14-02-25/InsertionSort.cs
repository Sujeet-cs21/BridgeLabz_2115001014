using System;

namespace PP_14_02_25
{
    class InsertionSort
    {
        public static int[] InsertionSorting(int[] ids)
        {
            for(int i=0;i<ids.Length;i++)
            {
                int key=ids[i];

                int j = i - 1;

                while(j >= 0 && ids[j]>key)
                {
                    ids[j + 1] = ids[j];
                    j--;
                }
                ids[j+1] = key;
            }
            return ids;
        }

        public static void Main2()
        {
            Console.Write("Enter number of Employees : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter IDs");
            int[] ids = new int[n];

            for (int i = 0; i < n; i++)
            {
                ids[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Sorted IDs : {string.Join(" ", InsertionSorting(ids))}");
        }
    }
}
