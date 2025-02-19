using System;
using System.Collections.Generic;

namespace PP_19_02_25
{
    class FrequencyOfElements
    {
        public static void Main2()
        {
            string[] fruits = {"apple","banana","apple","orange","orange","apple"};

            Dictionary<string,int> dict = new Dictionary<string,int>();
            foreach (string fruit in fruits)
            {
                if(dict.ContainsKey(fruit))
                    dict[fruit]++;
                else
                    dict.Add(fruit, 1);
            }

            foreach(var item in dict)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
