using System;

namespace PP_13_02_25
{
    class Stack
    {
        public int Data;
        public Stack Next;

        public Stack(int data)
        {
            Data = data;
        }
    }
    class UseStack
    {
        private Stack top;

        public void Push(int data)
        {
            Stack newData = new Stack(data);

            if (top == null)
            {
                top = newData;
                return;
            }

            newData.Next = top;
            top = newData;
        }

        public Stack Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
                return null;
            }
            Stack temp = top;
            top = top.Next;
            temp.Next = null;

            return temp;
        }

        public int Peek()
        {
            return top != null ? top.Data : -1;
        }

        public int Count(int data)
        {
            int count = 0;
            if (top == null)
                return 0;

            Stack temp = top;
            while(temp != null)
            {
                count++;
                temp = temp.Next;
            }
            return count;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public void PrintStack()
        {
            Stack temp = top;
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }
    }
}
