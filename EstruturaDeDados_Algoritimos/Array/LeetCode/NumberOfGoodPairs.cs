namespace EstruturaDeDados_Algoritimos.Array.LeetCode
{
    internal class NumberOfGoodPairs
    {
        public void Execute()
        {
            var arr = new int[] { 1, 1, 1, 1 };
            var result = Method(arr);

            Console.WriteLine("Array: ");
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\nResolved Array: ");
            Console.WriteLine($"GP: {result} ");
        }

        private int Method(int[] nums)
        {
            int p = 0;
            for (int i = 0; i < nums.Length; i++)
                for (int j = i + 1; j < nums.Length; j++)
                    if (nums[i] == nums[j])
                        p++;
            return p;
        }
    }
}
