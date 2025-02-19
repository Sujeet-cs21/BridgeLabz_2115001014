using System;
using System.Collections.Generic;

namespace PP_19_02_25
{
    class SetToSortedList
    {
        static List<int> ConvertSetToSortedList(HashSet<int> set)
        {
            List<int> sortedList = new List<int>(set);

            // Insertion Sort
            for (int i = 1; i < sortedList.Count; i++)
            {
                int key = sortedList[i];
                int j = i - 1;

                while (j >= 0 && sortedList[j] > key)
                {
                    sortedList[j + 1] = sortedList[j];
                    j = j - 1;
                }
                sortedList[j + 1] = key;
            }

            return sortedList;
        }

        public static void Main9()
        {
            HashSet<int> numbers = new HashSet<int> { 5, 3, 9, 1 };

            List<int> sortedList = ConvertSetToSortedList(numbers);

            Console.WriteLine("Sorted List: " + string.Join(" ", sortedList));
        }
    }

}
