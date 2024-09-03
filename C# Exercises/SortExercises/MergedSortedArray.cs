namespace SortExercises
{
    class MergedSortedArray
    {
        public MergedSortedArray()
        { }

        public void Main()
        {
            int[] nums1 = [1, 2, 3, 0, 0, 0];
            int m = 3; //representing the number of elements - array nums1
            int[] nums2 = [2, 5, 6];
            int n = 3; //representing the number of elements - array nums2

            Merge(nums1, m, nums2, n);
            Console.WriteLine($"Result: {String.Join(", ", nums1)}");
        }

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1; // Index of the last element in nums1's initial part
            int j = n - 1; // Index of the last element in nums2
            int k = m + n - 1; // Index of the last element in nums1

            while (j >= 0)
            {
                if (i >= 0 && nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    k--;
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    k--;
                    j--;
                }
            }
        }
    }
}