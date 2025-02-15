using System;
using System.Text;

namespace PP_15_02_25
{
    class PerformanceTest
    {
        public static void Main4()
        {
            long startTime, endTime;
            startTime = DateTime.Now.Ticks;

            string str = "Hello";
            for (int i = 0; i < 10000; i++)
            {
                str += " world";
            }
            endTime = DateTime.Now.Ticks;
            Console.WriteLine("String Performance Time : "+ (endTime-startTime)+" ticks");

            StringBuilder sb = new StringBuilder("Hello");
            startTime = DateTime.Now.Ticks;
            for (int i = 0;i <10000;i++)
            {
                sb.Append(" world");
            }
            endTime = DateTime.Now.Ticks;
            Console.WriteLine("StringBulilder Performance Time : " + (endTime - startTime) + " ticks");
        }
    }
}
