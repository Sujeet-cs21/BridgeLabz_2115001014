using System;
using System.Text;

namespace PP_15_02_25
{
    class StringConcatenation
    {
        public static void Main3()
        {
            Console.Write("Number Strings to be concatenated : ");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] strings = new string[n];
            Console.WriteLine("\nEnter Strings to be Concatenated : ");
            for(int i=0; i<strings.Length; i++)
                strings[i] = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            foreach (string s in strings)
            {
                sb.Append(s);
                sb.Append(" ");
            }

            Console.Write("New String : ");
            Console.WriteLine(sb);
        }
    }
}
