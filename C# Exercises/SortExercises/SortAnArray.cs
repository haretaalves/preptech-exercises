namespace SortExercises
{
    class SortAnArray
    {
        public SortAnArray()
        { }
        public void Main()
        {
            int[] nums = [5, 2, 3, 1];

            var selectionResult = SortArraySelectionSort(nums);
            Console.WriteLine($"Result using Selection Sort: {String.Join(", ", selectionResult)}");

            nums = [5, 1, 1, 2, 0, 0];
            var bubbleResult = SortArrayBubbleSort(nums);
            Console.WriteLine($"Result using Bubble Sort: {String.Join(", ", bubbleResult)}");

            nums = [7, 5, 8, 2, 4, 0];
            var mergeResult = SortArrayMergeSort(nums);
            Console.WriteLine($"Result using Merge Sort: {String.Join(", ", mergeResult)}");
        }

        public int[] SortArraySelectionSort(int[] nums)
        {
            int length = nums.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        (nums[i], nums[j]) = (nums[j], nums[i]);
                    }
                }
            }
            return nums;
        }

        public int[] SortArrayBubbleSort(int[] nums)
        {
            int length = nums.Length;
            for (int i = length - 1; i > 0; i--)
            {
                var anySwap = false;
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
                        anySwap = true;
                    }
                }

                if (!anySwap)
                {
                    break;
                }
            }
            return nums;
        }

        public int[] SortArrayMergeSort(int[] nums)
        {
            MergeSort(nums, 0, nums.Length - 1);
            return nums;
        }

        private void MergeSort(int[] nums, int left, int right)
        {
            if (left >= right)
                return;
            //get the index of the middle of the array   
            int mid = (left + right) / 2;

            //sorting 
            MergeSort(nums, left, mid); //sorting the left part - recursion
            MergeSort(nums, mid + 1, right); //sorting the right part - recursion            

            //merging
            int l = left, r = mid + 1;
            int[] merged = new int[right - left + 1];
            int i = 0;
            while (l <= mid && r <= right)
                if (nums[l] <= nums[r])
                    merged[i++] = nums[l++];
                else
                    merged[i++] = nums[r++];
            while (l <= mid)
                merged[i++] = nums[l++];
            while (r <= right)
                merged[i++] = nums[r++];

            //write the merged part into the main array
            i = 0;
            while (left <= right)
                nums[left++] = merged[i++];
        }
    }
}