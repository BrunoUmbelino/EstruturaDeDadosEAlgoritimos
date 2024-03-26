namespace EstruturaDeDados_Algoritimos.Array.LeetCode
{
    internal class LongestEvenOddSubarrayWithThreshold
    {
        public void Execute()
        {
            var arr = new int[] { 2, 3, 3, 10 };
            var result = Method(arr, 18);

            Console.WriteLine("Array: ");
            foreach (var i in arr)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\nR: ");
            Console.Write($"{result} ");
        }

        private int Method(int[] nums, int threshold)
        {
            var n = nums.Length;
            var longestSequence = 0;

            for (int l = 0; l < n; l++)
            {
                if (nums[l] > threshold || nums[l] % 2 != 0)
                    continue;

                int r = l + 1;
                while (r < n &&
                       nums[r] <= threshold &&
                       nums[r] % 2 != nums[r - 1] % 2)
                {
                    r++;
                }
                longestSequence = Math.Max(longestSequence, r - l);

            }

            return longestSequence;
        }

        private int Method2(int[] nums, int threshold)
        {
            var leng = nums.Length;
            var best = 0;

            for (int i = 0; i < leng; i++)
            {
                if (nums[i] % 2 != 0)
                    continue;
                if (nums[i] > threshold)
                    continue;

                for (int j = i; j < leng; j++)
                {
                    var good = true;

                    for (int k = i + 1; k < j + 1; k++)
                    {
                        if (nums[k] % 2 == nums[k - 1] % 2)
                            good = false;
                        if (nums[k] > threshold)
                            good = false;
                    }

                    if (good)
                        best = Math.Max(best, j - i + 1);
                }
            }
            return best;
        }

        private int Method3(int[] nums, int threshold)
        {
            int n = nums.Length;
            int largestSequence = 0;

            for (int l = 0; l < n; l++)
            {
                /// se curr for par e menor = limite
                if (nums[l] % 2 == 0 && nums[l] <= threshold)
                {
                    /// itera do segundo elemento até o ultimo
                    int r = l + 1;
                    while (r < n &&
                            nums[r] <= threshold &&
                            nums[r] % 2 != nums[r - 1] % 2)
                    {
                        r++;
                    }
                    largestSequence = Math.Max(largestSequence, r - l);
                }
            }
            return largestSequence;
        }
    }
}
