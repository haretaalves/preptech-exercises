namespace QueueExercises
{
    class NumberOfStudentsUnableToEat
    {
        public NumberOfStudentsUnableToEat()
        { }
        public void Main()
        {
            int[] students = [1, 1, 0, 0];
            int[] sandwiches = [0, 1, 0, 1];

            var result = CountStudents(students, sandwiches);
            Console.WriteLine(result);

            Console.WriteLine("-------");

            int[] students2 = [1, 1, 1, 0, 0, 1];
            int[] sandwiches2 = [1, 0, 0, 0, 1, 1];

            var result2 = CountStudents(students2, sandwiches2);
            Console.WriteLine(result2);

            Console.WriteLine("-------");

            int[] students3 = [0, 0, 0, 1, 0, 1, 1, 1, 1, 0, 1];
            int[] sandwiches3 = [0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0];

            var result3 = CountStudents(students3, sandwiches3);
            Console.WriteLine(result3);
        }

        public int CountStudents(int[] students, int[] sandwiches)
        {
            int i = 0;
            var studentsQueue = new Queue<int>(students);
            var sandwichesStack = new Stack<int>(sandwiches.Reverse());

            while (studentsQueue.Count > 0)
            {
                if (studentsQueue.Peek() == sandwichesStack.Peek())
                {
                    studentsQueue.Dequeue();
                    sandwichesStack.Pop();
                    i = 0;                    
                }
                else
                {
                    i++;

                    if (i > studentsQueue.Count)
                        break;

                    var item = studentsQueue.Dequeue();
                    studentsQueue.Enqueue(item);                    
                }
            }

            return studentsQueue.Count;
        }
    }
}