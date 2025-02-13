using System;

namespace PP_13_02_25
{
    class ZeroSumSubarrays
    {
        public static void FindZeroSumSubarrays(int[] arr)
        {
            HashMap sumMap = new HashMap(arr.Length);
            int cumulativeSum = 0;

            sumMap.Put(0, -1);

            for (int i = 0; i < arr.Length; i++)
            {
                cumulativeSum += arr[i];

                int? prevIndex = sumMap.Get(cumulativeSum);
                if (prevIndex != null)
                {
                    Console.WriteLine($"Subarray found from index {prevIndex + 1} to {i}");
                }
                else
                {
                    sumMap.Put(cumulativeSum, i);
                }
            }
        }

        public static void Main6()
        {
            int[] arr = { 3, 4, -7, 3, 1, 3, 1, -4, -2, -2 };
            FindZeroSumSubarrays(arr);
        }
    }

}
