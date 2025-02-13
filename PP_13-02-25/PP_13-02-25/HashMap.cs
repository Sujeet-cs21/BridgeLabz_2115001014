using System;

namespace PP_13_02_25
{
    class Entry
    {
        public int Key;
        public int Value;
        public Entry Next;

        public Entry(int key, int value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }
    class HashMap
    {
        private Entry[] buckets;
        private int capacity;

        public HashMap(int capacity)
        {
            this.capacity = capacity;
            buckets = new Entry[capacity];
        }

        private int GetHash(int key)
        {
            return Math.Abs(key) % capacity;
        }

        public void Put(int key, int value)
        {
            int index = GetHash(key);
            Entry head = buckets[index];

            while (head != null)
            {
                if (head.Key == key)
                {
                    head.Value = value;
                    return;
                }
                head = head.Next;
            }

            Entry newEntry = new Entry(key, value);
            newEntry.Next = buckets[index];
            buckets[index] = newEntry;
        }

        public int? Get(int key)
        {
            int index = GetHash(key);
            Entry head = buckets[index];

            while (head != null)
            {
                if (head.Key == key)
                    return head.Value;
                head = head.Next;
            }

            return null;
        }

        public void Remove(int key)
        {
            int index = GetHash(key);
            Entry head = buckets[index];
            Entry prev = null;

            while (head != null)
            {
                if (head.Key == key)
                {
                    if (prev == null)
                    {
                        buckets[index] = head.Next;
                    }
                    else
                    {
                        prev.Next = head.Next;
                    }
                    return;
                }
                prev = head;
                head = head.Next;
            }
        }

        public void Print()
        {
            for (int i = 0; i < capacity; i++)
            {
                Entry head = buckets[i];
                Console.Write($"Bucket {i}: ");
                while (head != null)
                {
                    Console.Write($"[{head.Key}: {head.Value}] -> ");
                    head = head.Next;
                }
                Console.WriteLine("NULL");
            }
        }

        public static void Main9()
        {
            HashMap map = new HashMap(10);
            map.Put(1, 100);
            map.Put(2, 200);
            map.Put(11, 300);
            map.Put(21, 400); 

            Console.WriteLine("Value for key 1: " + map.Get(1));
            Console.WriteLine("Value for key 2: " + map.Get(2));
            Console.WriteLine("Value for key 11: " + map.Get(11));
            Console.WriteLine("Value for key 21: " + map.Get(21));

            Console.WriteLine("\nBefore deletion:");
            map.Print();

            map.Remove(11);

            Console.WriteLine("\nAfter deletion:");
            map.Print();
        }
    }

}
