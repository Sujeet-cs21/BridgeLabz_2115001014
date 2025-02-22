using System.Threading;

namespace PP_22_02_25_NUnit
{
    public class NumberUtils1
    {
        public bool IsEven(int number) => number % 2 == 0;

        public void LongRunningTask()
        {
            Thread.Sleep(3000);
        }
    }
}
