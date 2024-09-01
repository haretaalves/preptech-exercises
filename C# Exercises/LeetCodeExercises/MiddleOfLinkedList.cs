namespace LinkedListsExercises
{
    class MiddleOfLinkedList
    {
        public MiddleOfLinkedList()
        { }
        public void Main()
        {
            var linkedList = new SingleLinkedList();

            //Testing insert operations
            linkedList.InsertBegin(3);
            linkedList.InsertEnd(4);
            linkedList.InsertEnd(1);
            linkedList.InsertEnd(5);
            linkedList.InsertEnd(7);

            linkedList.PrintList();

            Console.WriteLine("-------");

            Node result = MiddleNode(linkedList);

            Console.WriteLine($"Middle of Linked List {result.data}");
        }

        public Node MiddleNode(SingleLinkedList list)
        {
            int count = 0;
            Node current = list.head;

            // First iteration to count the number of nodes
            while (current != null)
            {
                count++;
                current = current.next;
            }

            // Reset current pointer for the second iteration
            current = list.head;

            // Second iteration to find the second middle node
            for (int i = 0; i < count / 2; i++)
            {
                current = current.next;
            }

            return current;
        }
    }
}
    