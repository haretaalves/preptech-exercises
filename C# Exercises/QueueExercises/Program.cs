using QueueExercises;

class Program
{
    static void Main()
    {

        var queueArrayMainOperations = new QueueArrayMainOperations();
        queueArrayMainOperations.Main();

        Console.WriteLine("-------");

        var queueLinkedListMainOperations = new QueueLinkedListMainOperations();
        queueLinkedListMainOperations.Main();

        Console.WriteLine("-------");

        var timeNeededToBuyTickets = new TimeNeededToBuyTickets();
        timeNeededToBuyTickets.Main();

    }

}