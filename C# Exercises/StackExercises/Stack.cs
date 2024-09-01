namespace StackExercises
{
    class Stack
    {
        int max;
        int top;
        int[] items;

        public Stack(int total)
        {
            max = total;
            top = -1;
            items = new int[total];
        }

        public bool IsEmpty() => items.Length == 0 ? true : false;

        public void Push(int data)
        {
            if (top >= max)
                return;
            else
                items[++top] = data;            
        }

        public int Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("The Stack is empty");

            int value = items[top--];
            return value;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("The Stack is empty");
            else               
                return items[top];
        }

        public void Print()
        {
            if (IsEmpty())
                return;

            for (int i = top; i > -1; i--)
            {
                Console.WriteLine(items[i]);
            }
        }

    }
}