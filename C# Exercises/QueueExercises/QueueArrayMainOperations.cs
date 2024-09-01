namespace QueueExercises
{
    class QueueArrayMainOperations
    {
        public QueueArrayMainOperations()
        { }
        public void Main()
        {
            var queueArray = new QueueArray(5);
            //Testing enqueue operation
            queueArray.Enqueue(1);
            queueArray.Enqueue(2);
            queueArray.Enqueue(3);
            queueArray.Print();
            Console.WriteLine("-------");

            //Testing dequeue operations
            var item = queueArray.Dequeue();
            Console.WriteLine($"Item removed: {item}");
            
            //Testing peek operation
            var front = queueArray.Peek();
            Console.WriteLine($"Top of stack: {front}");
            queueArray.Print();            
        }
    }
}