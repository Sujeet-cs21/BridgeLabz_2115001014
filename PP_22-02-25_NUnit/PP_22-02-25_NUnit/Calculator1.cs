using System;
namespace PP_22_02_25_NUnit
{
    public class Calculator1
    {
        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new ArithmeticException("Cannot divide by zero");
            return a / b;
        }
    }
}
