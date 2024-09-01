namespace QueueExercises
{
    class QueueArray
    {
        int max, front, rear;
        int[] items;

        public QueueArray(int total)
        {
            max = total;
            front = 0;
            rear = -1;
            items = new int[total];
        }

        public bool IsEmpty() => items.Length == 0 ? true : false;

        public void Enqueue(int data)
        {
            if (rear >= max)
                return;

            items[++rear] = data;
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The Queue is empty");
            }

            var data = items[front];
            for (int i = 0; i < rear; i++)
            {
                items[i] = items[i + 1];
            }
            rear--;
            return data;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("The Queue is empty");
            else
                return items[front];
        }

        public void Print()
        {
            if (IsEmpty())
                return;

            for (int i = front; i <= rear; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

    }
}