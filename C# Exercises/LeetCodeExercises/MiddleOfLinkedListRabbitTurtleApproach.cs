namespace LinkedListsExercises
{
    class MiddleOfLinkedListRabbitTurtleApproach
    {
        public MiddleOfLinkedListRabbitTurtleApproach()
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
}    