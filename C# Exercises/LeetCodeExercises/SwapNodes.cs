namespace LinkedListsExercises
{
    class SwapNodes
    {
        public SwapNodes()
        { }
        public void Main()
        {
            var linkedList = new SingleLinkedList();

            //Testing insert operations
            linkedList.insertBegin(3);
            linkedList.insertEnd(4);
            linkedList.insertEnd(1);
            linkedList.insertEnd(5);
            linkedList.insertEnd(7);

            linkedList.printList();

            Console.WriteLine("-------");

            var result = SwapNodesLinkedList(linkedList, 2);
            if (result != null) 
                result.printList();

            Console.WriteLine("-------");

            var resultInPairs = SwapNodesInPairs(linkedList);
            if (resultInPairs != null)
                resultInPairs.printList();

        }

        public SingleLinkedList SwapNodesLinkedList(SingleLinkedList list, int k)
        {
            if (list == null || list.head.next == null)
            {
                return list;
            }

            Node dummy = list.head;
            Node temp = list.head;
            int count = 1;
            Node firstNodeToSwap = null;
            while (temp != null)
            {
                if (count == k)
                    firstNodeToSwap = temp;

                if (count > k)
                    dummy = dummy.next;
                temp = temp.next;
                count++;
            }
            int secondNodeToSwap = dummy.data;
            dummy.data = firstNodeToSwap.data;
            firstNodeToSwap.data = secondNodeToSwap;

            return list;
        }

        public SingleLinkedList SwapNodesInPairs(SingleLinkedList list)
        {
            if (list == null || list.head.next == null)
            {
                return list;
            }

            Node current = list.head;
            Node next = list.head.next;

            list.head = next;

            Node prev = null;
            while (current != null && next != null)
            {
                current.next = next.next;
                next.next = current;

                if (prev != null)
                {
                    prev.next = next;
                }

                prev = current;

                current = current.next;
                if (current == null)
                {
                    break;
                }

                next = current.next;
                if (next == null)
                {
                    break;
                }
            }

            return list;
        }
    }
}
