using System;
using System.Collections.Generic;

namespace PP_19_02_25
{
    class RemoveDuplicateFromList
    {
        static List<int> RemoveDuplicates(List<int> list)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                bool isDuplicate = false;

                for (int j = 0; j < i; j++)
                {
                    if (list[i] == list[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    result.Add(list[i]);
                }
            }

            return result;
        }

        public static void Main4()
        {
            List<int> list = new List<int> { 3, 1, 2, 2, 3, 4 };

            List<int> uniqueList = RemoveDuplicates(list);

            Console.WriteLine("Unique List: " + string.Join(" ", uniqueList));
        }
    }
}
