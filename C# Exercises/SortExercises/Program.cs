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

        Console.WriteLine("-------");

        var minimumNumberOfMovesToSeat = new MinimumNumberOfMovesToSeat();
        minimumNumberOfMovesToSeat.Main();

        Console.WriteLine("-------");

        var maximumNumberOfCoins = new MaximumNumberOfCoins();
        maximumNumberOfCoins.Main();

        Console.WriteLine("-------");

        var countingSort = new CountingSort();
        countingSort.Main();

        Console.WriteLine("-------");

        var countingSortNotStableVersion = new CountingSortNotStableVersion();
        countingSortNotStableVersion.Main();

        Console.WriteLine("-------");

        var radixSort = new RadixSort();
        radixSort.Main();

    }

}