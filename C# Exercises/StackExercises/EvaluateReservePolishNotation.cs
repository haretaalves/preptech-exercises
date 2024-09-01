namespace StackExercises
{
    class EvaluateReservePolishNotation
    {
        public EvaluateReservePolishNotation()
        { }
        public void Main()
        {
            string[] tokens = ["2", "1", "+", "3", "*"];

            var result = EvalRPN(tokens);
            Console.WriteLine(result);
        }

        public int EvalRPN(string[] tokens)
        {
            var res = new Stack<int>();
            int temp = 0;
            for (int i = 0; i < tokens.Length; i++)
            {
                if (int.TryParse(tokens[i], out int num))
                {
                    res.Push(num);
                }
                else
                {
                    temp = res.Pop();
                    switch (tokens[i])
                    {
                        case "/":
                            temp = res.Pop() / temp;
                            break;
                        case "+":
                            temp = res.Pop() + temp;
                            break;
                        case "-":
                            temp = res.Pop() - temp;
                            break;
                        case "*":
                            temp = res.Pop() * temp;
                            break;
                    }
                    res.Push(temp);
                }
            }
            return res.Pop();
        }
    }
}