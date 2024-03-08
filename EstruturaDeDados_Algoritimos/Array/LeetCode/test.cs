namespace EstruturaDeDados_Algoritimos.Array.test
{
    internal class test
    {
        public void Execute()
        {
            var arr = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var result = RemoveDuplicates(arr);

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

        public int[] GetConcatenation(int[] nums)
        {
            var concatArr = new int[nums.Length * 2];
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                concatArr[i] = nums[i];
                concatArr[nums.Length + i] = nums[i];
            }

            return concatArr;
        }

        public int[] RemoveDuplicates(int[] nums)
        {
            for (var i = 0; i < nums.Length - 1; i++)
            {
                var atual = nums[i];
                var prox = nums[i + 1];
                if (atual == prox)
                {
                    // daqui até o final,
                    // joga tudo para esquerda
                }

            }

            return nums;
        }
    }
}
