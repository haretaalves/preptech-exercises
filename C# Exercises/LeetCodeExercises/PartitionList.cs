namespace LinkedListsExercises
{
    class PartitionList
    {
        public PartitionList()
        { }
        public void Main()
        {
            var linkedList = new SingleLinkedList();
            linkedList.InsertBegin(1);
            linkedList.InsertEnd(4);
            linkedList.InsertEnd(3);
            linkedList.InsertEnd(2);
            linkedList.InsertEnd(5);
            linkedList.InsertEnd(2);
            linkedList.PrintList();
            Console.WriteLine("-------");

            var result = Partition(linkedList, 3);
            if (result != null)
                result.PrintList();
        }

        public SingleLinkedList Partition(SingleLinkedList list, int x)
        {
            var linkedListMerge = new SingleLinkedList();

            var beforeX = new Node(0);
            var before = beforeX;

            var afterX = new Node(0);
            var after = afterX;

            while (list.head != null) 
            {
                if (list.head.data < x)
                {
                    before.next = list.head;
                    before = before.next;
                } else
                {
                    after.next = list.head;
                    after = after.next;
                }
                list.head = list.head.next;
            }

            after.next = null;
            before.next = afterX.next;

            linkedListMerge.head = beforeX.next;
            return linkedListMerge;
        }
    }
}
