namespace EstruturaDeDados_Algoritimos.Array.test
{
    internal class TwoSum
    {
        public void Execute()
        {
            var arr = new int[] { 3, 3 };
            var result = Sum(arr, 6);

            Console.WriteLine("Array: ");
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\nRotated Array: ");
            foreach (int i in result)
            {
                Console.Write($"{i} ");
            }
        }

        private IEnumerable<int> Sum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }
    }
}

