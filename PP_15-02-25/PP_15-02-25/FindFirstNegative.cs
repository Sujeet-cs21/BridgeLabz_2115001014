using System;

namespace PP_15_02_25
{
    class FindFirstNegative
    {
        public static void Main9()
        {
            Console.Write("Enter Size of Array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
                nums[i] = Convert.ToInt32(Console.ReadLine());

            //Linear Search to find first -ve number
            for (int i = 0; i < n; i++)
            {
                if (nums[i] < 0)
                {
                    Console.WriteLine($"first -ve Number {nums[i]} found at index {i}");
                    return;
                }
            }
            Console.WriteLine("Given Array has no -ve number");
        }
    }
}
