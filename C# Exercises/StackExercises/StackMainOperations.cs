namespace StackExercises
{
    class StackMainOperations
    {
        public StackMainOperations()
        { }
        public void Main()
        {
            var stack = new Stack(3);
            //Testing push operation
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Print();
            Console.WriteLine("-------");

            //Testing pop operations
            var item = stack.Pop();
            Console.WriteLine($"Item removed: {item}");
            
            //Testing peek operation
            var top = stack.Peek();
            Console.WriteLine($"Top of stack: {top}");
            stack.Print();            
        }
    }
}