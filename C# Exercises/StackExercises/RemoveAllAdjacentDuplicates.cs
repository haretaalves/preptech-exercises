namespace StackExercises
{
    class RemoveAllAdjacentDuplicates
    {
        public RemoveAllAdjacentDuplicates()
        { }
        public void Main()
        {
            string word = "abbaca";

            var result = RemoveDuplicates(word);
            Console.WriteLine(result);
        }

        public string RemoveDuplicates(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (stack.Count == 0)
                {
                    stack.Push(s[i]);
                }                    
                else
                {
                    if (s[i] == stack.Peek())
                        stack.Pop();
                    else
                        stack.Push(s[i]);
                }
            }
            return string.Concat(stack.Reverse());
        }
    }
}