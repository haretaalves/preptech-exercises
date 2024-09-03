namespace SortExercises
{
    class SquaresOfSortedArray
    {
        public SquaresOfSortedArray()
        { }

        public void Main()
        {
            int[] nums = [-4, -1, 0, 3, 10];

            var result = SortedSquares(nums);
            Console.WriteLine($"Result: {String.Join(", ", result)}");
        }

        public int[] SortedSquares(int[] nums)
        {
            int[] result = new int[nums.Length];
            int left = 0;
            int right = nums.Length - 1;
            int i = nums.Length - 1;

            while (left <= right)
            {
                //compare absolute values
                if (Math.Abs(nums[left]) < Math.Abs(nums[right]))
                {
                    result[i] = nums[right] * nums[right];
                    i--;
                    right--;
                }
                else
                {
                    result[i] = nums[left] * nums[left];
                    i--;
                    left++;
                }
            }

            return result;
        }
    }
}
