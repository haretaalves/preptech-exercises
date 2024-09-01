namespace LinkedListsExercises
{
    class MergeTwoSortedLists
    {
        public MergeTwoSortedLists()
        { }
        public void Main()
        {
            var linkedList1 = new SingleLinkedList();
            linkedList1.InsertBegin(1);
            linkedList1.InsertEnd(2);
            linkedList1.InsertEnd(4);
            linkedList1.PrintList();

            Console.WriteLine("-------");

            var linkedList2 = new SingleLinkedList();
            linkedList2.InsertBegin(1);
            linkedList2.InsertEnd(3);
            linkedList2.InsertEnd(4);
            linkedList2.PrintList();

            Console.WriteLine("-------");

            var result = MergeTwoLists(linkedList1, linkedList2);
            if (result != null)
                result.PrintList();

        }

        public SingleLinkedList MergeTwoLists(SingleLinkedList list1, SingleLinkedList list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            var linkedListMerge = new SingleLinkedList();

            var dummyNode = new Node(0);
            var tail = dummyNode;

            var pointer1 = list1;
            var pointer2 = list2;

            while (pointer1.head != null && pointer2.head != null)
            {
                if (pointer1.head.data < pointer2.head.data)
                {
                    tail.next = pointer1.head;
                    pointer1.head = pointer1.head.next;
                }
                else
                {
                    tail.next = pointer2.head;
                    pointer2.head = pointer2.head.next;
                }

                tail = tail.next;
            }

            tail.next = pointer1.head ?? pointer2.head;

            linkedListMerge.head = dummyNode.next;
            return linkedListMerge;
        }
    }
}
