using System;
using System.Collections.Generic;

namespace PP_19_02_25
{
    class SymmetricDifference
    {
        static List<T> FindSymmetricDifference<T>(List<T> set1, List<T> set2)
        {
            List<T> result = new List<T>();

            foreach (T item in set1)
            {
                if (!set2.Contains(item))
                    result.Add(item);
            }

            foreach (T item in set2)
            {
                if (!set1.Contains(item))
                    result.Add(item);
            }

            return result;
        }

        public static void Main8()
        {
            List<int> set1 = new List<int> { 1, 2, 3 };
            List<int> set2 = new List<int> { 3, 4, 5 };

            List<int> symmetricDiff = FindSymmetricDifference(set1, set2);

            Console.WriteLine("Symmetric Difference: " + string.Join(" ", symmetricDiff));
        }
    }

}
