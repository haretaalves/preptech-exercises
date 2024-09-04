namespace SortExercises
{
    class MaximumNumberOfCoins
    {
        public MaximumNumberOfCoins()
        { }
        public void Main()
        {
            int[] piles = [9, 8, 7, 6, 5, 1, 2, 3, 4];

            var result = MaxCoins(piles);
            Console.WriteLine($"Result: {result}");
        }

        public int MaxCoins(int[] piles)
        {
            Array.Sort(piles);

            int myCoins = 0;
            int i = 0;
            int myPos = piles.Length - 2;
            while (i < myPos)
            {
                myCoins += piles[myPos];
                Console.WriteLine($"My Coins: {myCoins}");
                myPos -= 2;
                i++;
            }

            return myCoins;

        }
    }
}
