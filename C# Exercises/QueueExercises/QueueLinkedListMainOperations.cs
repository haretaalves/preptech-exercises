namespace QueueExercises
{
    class QueueLinkedListMainOperations
    {
        public QueueLinkedListMainOperations()
        { }
        public void Main()
        {
            var queueLinkedList = new QueueLinkedList();
            //Testing enqueue operation
            queueLinkedList.Enqueue(9);
            queueLinkedList.Enqueue(8);
            queueLinkedList.Enqueue(7);
            queueLinkedList.Print();
            Console.WriteLine("-------");

            //Testing dequeue operations
            var item = queueLinkedList.Dequeue();
            Console.WriteLine($"Item removed: {item}");
            
            //Testing peek operation
            var front = queueLinkedList.Peek();
            Console.WriteLine($"Top of stack: {front}");
            queueLinkedList.Print();            
        }
    }
}