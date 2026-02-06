using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    internal class ListNodeMain
    {
        public static void Main(string[] args)
        {
            CustomLinkedList list1 = new CustomLinkedList();
            list1.Add(0);
            list1.Add(399);
            list1.Add(699);

            CustomLinkedList list2 = new CustomLinkedList();
            list2.Add(1);
            list2.Add(499);
            list2.Add(599);

            CustomLinkedList merged = CustomLinkedList.Merge(list1, list2);

            merged.Print();
        }
    }
}
