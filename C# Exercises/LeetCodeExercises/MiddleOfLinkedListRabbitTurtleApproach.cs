class MiddleOfLinkedListRabbitTurtleApproach
{
    public MiddleOfLinkedListRabbitTurtleApproach()
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

        Node? result = MiddleNode(linkedList);

        if (result != null)
        {
            Console.WriteLine($"Middle of Linked List using Rabbit&Turtle Approach: {result.data}");
        }
    }

    public Node? MiddleNode(SingleLinkedList list)
    {
        if (list.head is null) 
            return null;

        //fasterPtr walks twice as fast output
        Node turtle = list.head;
        Node rabbit = list.head;

        //loop through the linked list until fasterPtr becomes null-pointer
        while (rabbit != null && rabbit.next != null)
        {
            turtle = turtle.next;
            rabbit = rabbit.next.next;
        }

        return turtle;
    }
}