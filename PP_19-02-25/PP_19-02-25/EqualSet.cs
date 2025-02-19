using System;
using System.Collections.Generic;

namespace PP_19_02_25
{
    class EqualSet
    {
        static bool AreSetsEqual<T>(List<T> set1, List<T> set2)
        {
            if (set1.Count != set2.Count)
                return false;

            set1.Sort();
            set2.Sort();

            for (int i = 0; i < set1.Count; i++)
            {
                if (!set1[i].Equals(set2[i]))
                    return false;
            }

            return true;
        }

        public static void Main6()
        {
            List<int> set1 = new List<int> { 1, 2, 3 };
            List<int> set2 = new List<int> { 3, 2, 1 };

            Console.WriteLine("Are sets equal? " + AreSetsEqual(set1, set2));
        }
    }
}
