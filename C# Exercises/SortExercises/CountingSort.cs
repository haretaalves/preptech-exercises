namespace SortExercises
{
    class CountingSort
    {
        public CountingSort()
        { }

        public void Main()
        {
            int[] nums = [3, 1, 4, 8, 0, 7, 2, 1, 8, 3];

            var result = Sort(nums);
            Console.WriteLine($"Result: {String.Join(", ", result)}");
        }

        public int[] Sort(int[] nums)
        {
            int maxValue = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > maxValue)
                {
                    maxValue = nums[i];
                }
            }
            //Console.WriteLine($"MaxValue: {maxValue}");     

            var countingArray = new int[maxValue + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                //var pos = nums[i];
                //var originalValue = countingArray[nums[i]];
                countingArray[nums[i]] = countingArray[nums[i]] + 1;
            }
            //Console.WriteLine($"CountingArray: {String.Join(", ", countingArray)}");

            var sum = 0;
            for (int i = 0; i < countingArray.Length; i++)
            {
                countingArray[i] = countingArray[i] + sum;
                sum = countingArray[i];
            }
            //Console.WriteLine($"CountingArray after sum: {String.Join(", ", countingArray)}");

            var result = new int[nums.Length];
            for (int i = nums.Length; i > 0; i--)
            {
                int value = nums[i - 1];
                //int position = countingArray[value];
                result[countingArray[value] - 1] = value;
                countingArray[value] = countingArray[value] - 1;
            }
            //Console.WriteLine($"CountingArray after sum: {String.Join(", ", result)}");

            return result;
        }
    }
}
