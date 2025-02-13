using System;

namespace PP_13_02_25
{

    class Queue
    {
        private int[] data;
        private int front, rear, size, capacity;

        public Queue(int capacity)
        {
            this.capacity = capacity;
            data = new int[capacity];
            front = 0;
            rear = -1;
            size = 0;
        }

        public void Enqueue(int value)
        {
            if (size == capacity)
            {
                Console.WriteLine("out of Capacity");
                return;
            }
            rear = (rear + 1) % capacity;
            data[rear] = value;
            size++;
        }

        public int Dequeue()
        {
            if (size == 0)
            {
                Console.WriteLine("Queue empty");
                return -1;
            }
            int value = data[front];
            front = (front + 1) % capacity;
            size--;
            return value;
        }

        public int Front()
        {
            return data[front];
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public int Size()
        {
            return size;
        }
    }

    class CircularTour
    {
        public static int FindStartingPoint(int[] petrol, int[] distance)
        {
            int n = petrol.Length;
            Queue queue = new Queue(n);

            int total = 0;
            int current = 0;
            int start = 0;

            for (int i = 0; i < n; i++)
            {
                int balance = petrol[i] - distance[i];
                total += balance;
                current += balance;

                queue.Enqueue(i);

                //remove pumps from the queue which have not petrol
                while (current < 0 && !queue.IsEmpty())
                {
                    int removedIndex = queue.Dequeue();
                    current -= petrol[removedIndex] - distance[removedIndex];
                    start = removedIndex + 1;
                }
            }

            return total >= 0 ? start : -1;
        }

        public static void Main5()
        {
            int[] petrol = { 4, 6, 7, 4 };
            int[] distance = { 6, 5, 3, 5 };

            int start = FindStartingPoint(petrol, distance);

            Console.WriteLine(start == -1 ? "No circular tour possible" : "Start at petrol pump: " + start);
        }
    }

}
