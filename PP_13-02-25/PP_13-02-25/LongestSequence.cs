using System;

namespace PP_13_02_25
{
    class LongestSequence
    {
        public static int LongestConsecutiveSequence(int[] arr)
        {
            HashMap map = new HashMap(arr.Length);
            foreach (int num in arr)
            {
                map.Put(num, 1);
            }

            int longestStreak = 0;
            foreach (int num in arr)
            {
                if (map.Get(num - 1) == null)
                {
                    int currentNum = num;
                    int currentStreak = 1;

                    while (map.Get(currentNum + 1) != null)
                    {
                        currentNum += 1;
                        currentStreak += 1;
                    }

                    longestStreak = Math.Max(longestStreak, currentStreak);
                }
            }

            return longestStreak;
        }

        public static void Main8()
        {

            int[] arr3 = { 100, 4, 200, 1, 3, 2 };
            Console.WriteLine("Longest Consecutive Sequence Length: " + LongestConsecutiveSequence(arr3));
        }
    }

}
