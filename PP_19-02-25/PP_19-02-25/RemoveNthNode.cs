using System;

namespace PP_19_02_25
{
    class Node
    {
        public char Data;
        public Node Next;

        public Node(char data)
        {
            Data = data;
            Next = null;
        }
    }

    class LinkedList
    {
        public Node Head;

        // Function to find the Nth element from the end
        public char FindNthFromEnd(int N)
        {
            Node first = Head, second = Head;

            // Move `first` N steps ahead
            for (int i = 0; i < N; i++)
            {
                if (first == null)
                {
                    Console.WriteLine("N is larger than the length of the list.");
                    return ' ';
                }
                first = first.Next;
            }

            // Move both pointers until `first` reaches the end
            while (first != null)
            {
                first = first.Next;
                second = second.Next;
            }

            return second.Data;
        }
    }

    class RemoveNthNode
    {
        public static void Main5()
        {
            LinkedList list = new LinkedList();
            list.Head = new Node('A');
            list.Head.Next = new Node('B');
            list.Head.Next.Next = new Node('C');
            list.Head.Next.Next.Next = new Node('D');
            list.Head.Next.Next.Next.Next = new Node('E');

            int N = 2;
            Console.WriteLine("Nth element from the end: " + list.FindNthFromEnd(N));
        }
    }
}
