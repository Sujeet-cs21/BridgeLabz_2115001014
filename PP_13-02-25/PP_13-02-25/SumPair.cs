using System;

namespace PP_13_02_25
{

    class SumPair
    {
        public static bool HasPairWithSum(int[] arr, int target)
        {
            HashMap map = new HashMap(arr.Length);

            for (int i = 0; i < arr.Length; i++)
            {
                int complement = target - arr[i];
                if (map.Get(complement) != null)
                {
                    Console.WriteLine($"Pair found: ({arr[i]}, {complement})");
                    return true;
                }
                map.Put(arr[i], i);
            }
            return false;
        }

        public static void Main7()
        {
            int[] arr2 = { 1, 2, 3, 9, 4, 5 };
            int target = 8;
            Console.WriteLine("Has pair with sum " + target + ": " + HasPairWithSum(arr2, target));
        }
    }

}
