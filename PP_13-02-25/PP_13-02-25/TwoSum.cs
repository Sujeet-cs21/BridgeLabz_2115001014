using System;

namespace PP_13_02_25
{
    
    class TwoSum
    {
        public static int[] SumTwo(int[] nums, int target)
        {
            HashMap map = new HashMap(nums.Length);
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                int? index = map.Get(complement);
                if (index != null)
                {
                    return new int[] { index.Value, i };
                }
                map.Put(nums[i], i);
            }
            return new int[0];
        }

        public static void Main10()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] result = SumTwo(nums, target);
            if (result.Length > 0)
            {
                Console.WriteLine($"Two Sum indices: [{result[0]}, {result[1]}]");
            }
            else
            {
                Console.WriteLine("No Two Sum solution found");
            }
        }
    }

}
