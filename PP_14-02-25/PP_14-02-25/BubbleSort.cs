using System;

namespace PP_14_02_25
{
    class BubbleSort
    {
        public static int[] BubbleSorting(int[] marks)
        {
            int n=marks.Length;

            for (int i = 0; i < n-1; i++)
            {
                bool swapped = false;
                for (int j = 0;j<n-i-1;j++)
                {
                    if(marks[j] > marks[j+1])
                    {
                        (marks[j], marks[j + 1]) = (marks[j + 1], marks[j]);
                        swapped = true;
                    }
                }
                if(!swapped)
                    break;
            }
            return marks;
        }

        public static void Main1()
        {
            Console.Write("Enter number of Students : ");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter Marks");
            int[] marks = new int[n];

            for(int i = 0;i < n;i++)
            {
                marks[i]= Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Sorted Marks : {string.Join(" ",BubbleSorting(marks))}");
        }
    }
}
