using StackExercises;

class Program
{
    static void Main()
    {
        var stackMainOperations = new StackMainOperations();
        stackMainOperations.Main();

        Console.WriteLine("-------");

        var evaluateReservePolishNotation = new EvaluateReservePolishNotation();
        evaluateReservePolishNotation.Main();

        Console.WriteLine("-------");

        var removeAllAdjacentDuplicates = new RemoveAllAdjacentDuplicates();
        removeAllAdjacentDuplicates.Main();

    }

}