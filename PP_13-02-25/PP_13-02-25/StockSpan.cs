using System;

namespace PP_13_02_25
{
    class StockSpan
    {
        public static int[] CalculateStockSpan(int[] prices)
        {
            int n = prices.Length;
            int[] span = new int[n];
            UseStack stack = new UseStack();

            for (int i = 0; i < n; i++)
            {
                // Pop elements from stack while the current price is higher
                while (!stack.IsEmpty() && prices[stack.Peek()] <= prices[i])
                {
                    stack.Pop();
                }

                // If stack is empty, span is (i + 1), else (i - stack.Peek())
                span[i] = stack.IsEmpty() ? (i + 1) : (i - stack.Peek());

                // Push current index to stack
                stack.Push(i);
            }
            return span;
        }

        public static void Main3()
        {
            int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
            int[] spans = CalculateStockSpan(prices);

            Console.WriteLine("Stock Prices: " + string.Join(" ", prices));
            Console.WriteLine("Stock Span  : " + string.Join(" ", spans));
        }
    }
}
