namespace QueueExercises
{
    class TimeNeededToBuyTickets
    {
        public TimeNeededToBuyTickets()
        { }
        public void Main()
        {
            int[] tickets = [2, 3, 2];
            int k = 2;

            var result = TimeRequiredToBuy(tickets, k);
            Console.WriteLine(result);
        }

        public int TimeRequiredToBuy(int[] tickets, int k)
        {
            var queue = new Queue<int>();

            for (int i = 0; i < tickets.Length; i++)
                queue.Enqueue(i);

            int time = 0;
            while (true)
            {
                var personIndex = queue.Dequeue();
                //Console.WriteLine(personIndex);
                tickets[personIndex]--;
                time++;
                if (tickets[personIndex] == 0)
                {
                    if (personIndex == k)
                        return time;
                    continue;
                }
                queue.Enqueue(personIndex);
            }

            return 0;
        }
    }
}