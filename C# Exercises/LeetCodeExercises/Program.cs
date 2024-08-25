class Program
{
    static void Main()
    {
        var linkedListMainOperations = new LinkedListMainOperations();
        linkedListMainOperations.Main();

        Console.WriteLine("-------");

        var middleOfLinkedList = new MiddleOfLinkedList();
        middleOfLinkedList.Main();

        Console.WriteLine("-------");

        var rabbitTurtleApproach = new MiddleOfLinkedListRabbitTurtleApproach();
        rabbitTurtleApproach.Main();

    }
}
