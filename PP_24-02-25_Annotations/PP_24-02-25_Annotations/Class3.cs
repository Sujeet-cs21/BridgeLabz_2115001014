using System;
using System.Collections;

namespace PP_24_02_25_Annotations
{
    class Class3
    {
        // Disables warnings related to nullable conversion
        #pragma warning disable CS8600
        // Disables warnings for possible null dereference
        #pragma warning disable CS8602 

        public static void Main3()
        {
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add("Hello");
            list.Add(3.14);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        // Re-enable warnings
        #pragma warning restore CS8600
        #pragma warning restore CS8602
    }
}
