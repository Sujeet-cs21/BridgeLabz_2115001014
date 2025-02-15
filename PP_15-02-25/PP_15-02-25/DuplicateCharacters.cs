using System;
using System.Text;

namespace PP_15_02_25
{
    class DuplicateCharacters
    {
        public static string RemoveDuplicates(string str)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in str)
            {
                bool seen = false;
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] == c)
                    {
                        seen = true;
                        break;
                    }
                }

                if (!seen)
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }

        public static void Main2()
        {
            Console.Write("Input String : ");
            StringBuilder sb = new StringBuilder(Console.ReadLine());

            Console.Write("Modified String : ");
            sb = new StringBuilder(RemoveDuplicates(sb.ToString()));
            Console.WriteLine(sb);
        }
    }
}
