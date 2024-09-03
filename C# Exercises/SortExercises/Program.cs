using SortExercises;

class Program
{
    static void Main()
    {
        var sortAnArray = new SortAnArray();
        sortAnArray.Main();

        Console.WriteLine("-------");

        var mergedSortedArray = new MergedSortedArray();
        mergedSortedArray.Main();

        Console.WriteLine("-------");

        var squaresOfSortedArray = new SquaresOfSortedArray();
        squaresOfSortedArray.Main();

    }

}