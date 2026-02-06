using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    internal class CustomLinkedList
    {
        public Node head;

        //Adding Node at the place where it want
        public void Add(int value)
        {
            Node newNode = new Node(value);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = newNode;
        }
        //Merging 2 Linked List By Making Custom Linked List
        public static CustomLinkedList Merge(CustomLinkedList l1, CustomLinkedList l2)
        {
            CustomLinkedList result = new CustomLinkedList();

            Node p1 = l1.head;
            Node p2 = l2.head;

            while (p1 != null && p2 != null)
            {
                if (p1.value < p2.value)
                {
                    result.Add(p1.value);
                    p1 = p1.next;
                }
                else
                {
                    result.Add(p2.value);
                    p2 = p2.next;
                }
            }
            while (p1 != null)
            {
                result.Add(p1.value);
                p1 = p1.next;
            }

            while (p2 != null)
            {
                result.Add(p2.value);
                p2 = p2.next;
            }

            return result;
        }
        //Printing The Node Values Of An Linked List To The Console
        public void Print()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.value + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}