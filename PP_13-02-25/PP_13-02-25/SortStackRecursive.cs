using System;

namespace PP_13_02_25
{
    class SortStackRecursive
    {
        private UseStack stack = new UseStack();

        public void AddElements(int num)
        {
            stack.Push(num);
        }

        // Recursive function to sort the stack
        public void SortStack()
        {
            if (!stack.IsEmpty())
            {
                int temp = stack.Pop().Data;
                SortStack();
                InsertSorted(temp);
            }
        }

        //inserting element at the correct position
        private void InsertSorted(int value)
        {
            if (stack.IsEmpty() || stack.Peek() >= value)
            {
                stack.Push(value);
                return;
            }

            int temp = stack.Pop().Data;
            InsertSorted(value);
            stack.Push(temp);
        }

        public void DisplayStack()
        {
            stack.PrintStack();
        }

        public static void Main2()
        {
            SortStackRecursive stack1 = new SortStackRecursive();
            stack1.AddElements(1);
            stack1.AddElements(4);
            stack1.AddElements(3);
            stack1.AddElements(5);
            stack1.AddElements(2);

            Console.WriteLine("Original Stack:");
            stack1.DisplayStack();

            stack1.SortStack();

            Console.WriteLine("Sorted Stack:");
            stack1.DisplayStack();
        }
    }
}
