namespace LinkedListsExercises
{
    class LinkedListMainOperations
    {
        public LinkedListMainOperations()
        { }
        public void Main()
        {
            var linkedList = new SingleLinkedList();

            //Testing insert operations
            linkedList.InsertBegin(1);
            linkedList.InsertBegin(2);
            linkedList.InsertBegin(3);

            linkedList.InsertEnd(4);

            linkedList.InsertAfterPosition(5, 2);

            linkedList.PrintList();

            Console.WriteLine("-------");

            //Testing remove operations

            linkedList.RemoveBegin();
            linkedList.RemoveEnd();

            linkedList.PrintList();
            Console.WriteLine("-------");


            linkedList.InsertEnd(6);
            linkedList.PrintList();
            Console.WriteLine("-------");

            linkedList.RemoveAtPosition(2);

            linkedList.PrintList();

            //Testing search operation
            linkedList.Find(6);
            linkedList.Find(8);

            //Testing revert operation
            linkedList.Revert();
            Console.WriteLine($"Head of linked list reverted is: {linkedList.head.data}");

            linkedList.PrintList();
        }
    }
}