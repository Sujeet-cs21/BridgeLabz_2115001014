using System;
using System.Collections.Generic;

namespace PP_19_02_25
{
    class Union_Intesection
    {
        static List<T> Union<T> (List<T> set1, List<T> set2)
        {
            List<T> unionSet = new List<T>(set1);

            foreach (T item in set2)
            {
                if (!unionSet.Contains(item))
                    unionSet.Add(item);
            }

            return unionSet;
        }

        static List<T> Intersection<T> (List<T> set1, List<T> set2)
        {
            List<T> intersectionSet = new List<T>();

            foreach (T item in set1)
            {
                if (set2.Contains(item) && !intersectionSet.Contains(item))
                    intersectionSet.Add(item);
            }

            return intersectionSet;
        }

        public static void Main7()
        {
            List<int> set1 = new List<int> { 1, 2, 3 };
            List<int> set2 = new List<int> { 3, 4, 5 };

            List<int> unionResult = Union(set1, set2);
            List<int> intersectionResult = Intersection(set1, set2);

            Console.WriteLine("Union: " + string.Join(" ", unionResult));
            Console.WriteLine("Intersection: " + string.Join(" ", intersectionResult));
        }
    }

}
