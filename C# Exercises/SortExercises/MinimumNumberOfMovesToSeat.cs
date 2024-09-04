namespace SortExercises
{
    class MinimumNumberOfMovesToSeat
    {
        public MinimumNumberOfMovesToSeat()
        {

        }
        public void Main()
        {
            int[] seats = [3, 1, 5];
            int[] students = [2, 7, 4];

            var result = MinMovesToSeat(seats, students);
            Console.WriteLine($"Result: {result}");
        }

        public int MinMovesToSeat(int[] seats, int[] students)
        {
            Array.Sort(seats);
            Array.Sort(students);

            int count = 0;
            for (int i = 0; i < seats.Length; i++)
            {
                var qty = students[i] - seats[i];
                if (Math.Abs(qty) > 0)
                {
                    count += Math.Abs(qty);
                }
            }

            return count;
        }
    }
}
