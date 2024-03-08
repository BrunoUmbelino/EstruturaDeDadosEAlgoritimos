namespace EstruturaDeDados_Algoritimos.Array.LeetCode
{
    internal class RemoveDuplicateFromSortedArr
    {
        public void Execute()
        {
            var nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var result = RemoveDuplicateFromSortedArr2(nums);

            Console.WriteLine("Array: ");
            foreach (int i in nums)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n" + result);
        }

        private int RemoveDuplicateFromSortedArr2(int[] nums)
        {
            var pUnico = 1;
            for (int pInterador = 1; pInterador < nums.Length; pInterador++)
            {
                if (nums[pInterador] != nums[pInterador - 1])
                {
                    nums[pUnico] = nums[pInterador];
                    pUnico++;
                }
            }
            return pUnico;
        }
    }
}
