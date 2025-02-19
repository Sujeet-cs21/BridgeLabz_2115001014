using System;
using System.Collections;
using System.Collections.Generic;

namespace PP_19_02_25
{

    class ReverseList
    {
        //ReverseArrayList Method
        static void ReverseArrayList(ArrayList list)
        {
            int left = 0, right = list.Count - 1;
            while (left < right)
            {
                (list[left], list[right]) = (list[right], list[left]);
                left++;
                right--;
            }
        }

        //ReverseLinkedList Method
        static void ReverseLinkedList(LinkedList<int> list)
        {
            if (list.Count <= 1)
                return;

            LinkedListNode<int> current = list.First;
            while (current.Next != null)
            {
                LinkedListNode<int> next = current.Next;
                list.Remove(next);
                list.AddFirst(next);
            }
        }

        //Main method
        public static void Main1()
        {
            //creating ArrayList and LinkedList
            ArrayList arrayList = new ArrayList { 1, 2, 3, 4, 5 };
            LinkedList<int> linkedList = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });

            // calling Reverse methods
            ReverseArrayList(arrayList);
            ReverseLinkedList(linkedList);

            //printing the reversed list
            Console.WriteLine("Reversed ArrayList: " + string.Join(" ", arrayList.ToArray()));
            Console.Write("Reversed LinkedList: ");
            foreach (var item in linkedList)
            {
                Console.Write(item + " ");
            }
        }
    }

}
