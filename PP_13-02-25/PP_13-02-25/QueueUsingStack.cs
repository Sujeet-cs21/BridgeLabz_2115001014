using System;

namespace PP_13_02_25
{

    class QueueUsingStack
    {
        private UseStack enqueueStack = new UseStack();
        private UseStack dequeueStack = new UseStack();

        // Enqueue operation
        public void Enqueue(int data)
        {
            enqueueStack.Push(data);
        }

        // Dequeue operation 
        public int Dequeue()
        {
            if (dequeueStack.IsEmpty())
            {
                if (enqueueStack.IsEmpty())
                {
                    Console.WriteLine("Queue is Empty");
                    return -1;
                }

                // Transfer elements from enqueueStack to dequeueStack
                while (!enqueueStack.IsEmpty())
                {
                    dequeueStack.Push(enqueueStack.Pop().Data);
                }
            }
            return dequeueStack.Pop().Data;
        }

        // Peek operation
        public int Peek()
        {
            if (dequeueStack.IsEmpty())
            {
                if (enqueueStack.IsEmpty())
                {
                    Console.WriteLine("Queue is Empty");
                    return -1;
                }

                // Transfer elements if necessary
                while (!enqueueStack.IsEmpty())
                {
                    dequeueStack.Push(enqueueStack.Pop().Data);
                }
            }
            return dequeueStack.Peek();
        }

        // Check if queue is empty
        public bool IsEmpty()
        {
            return enqueueStack.IsEmpty() && dequeueStack.IsEmpty();
        }
        public static void Main1()
        {
            QueueUsingStack queue = new QueueUsingStack();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());

            queue.Enqueue(4);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
        }
    }
}
