namespace SortExercises
{
    class CountingSortNotStableVersion
    {
        public CountingSortNotStableVersion()
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

            var countingArray = new int[maxValue + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                countingArray[nums[i]] = countingArray[nums[i]] + 1;
            }

            int j = 0;
            int k = 0;
            while (k < countingArray.Length && j < nums.Length)
            {
                if (countingArray[k] > 0)
                {
                    nums[j] = k;
                    countingArray[k] = countingArray[k] - 1;
                    j++;
                }

                if (countingArray[k] == 0)
                {
                    k++;
                }
            }

            return nums;
        }
    }
}
