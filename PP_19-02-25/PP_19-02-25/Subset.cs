using System;
using System.Collections.Generic;

namespace PP_19_02_25
{
    class Subset
    {
        static bool IsSubset<T>(HashSet<T> set1, HashSet<T> set2)
        {
            foreach (T item in set1)
            {
                if (!set2.Contains(item))
                    return false;
            }
            return true;
        }

        public static void Main10()
        {
            HashSet<int> set1 = new HashSet<int> { 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 1, 2, 3, 4 };

            Console.WriteLine("Is set1 a subset of set2? " + IsSubset(set1, set2));
        }
    }

}
