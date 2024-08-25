class MiddleOfLinkedList
{
    public MiddleOfLinkedList()
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