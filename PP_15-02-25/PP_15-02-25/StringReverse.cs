using System;
using System.Text;

namespace PP_15_02_25
{
    class StringReverse
    {
        public static string ReverseString(string str)
        {
            StringBuilder result = new StringBuilder(str);
            int i=0,j=result.Length-1;
            while (i < j)
            {
                (result[i], result[j]) = (result[j], result[i]);
                i++;
                j--;
            }
            return result.ToString();
        }
        public static void Main1()
        {
            Console.Write("Input String : ");
            StringBuilder sb = new StringBuilder(Console.ReadLine());

            Console.Write("Reversed String : ");
            sb = new StringBuilder(ReverseString(sb.ToString()));
            Console.WriteLine(sb);
        }
    }
}
