namespace EstruturaDeDados_Algoritimos.Array.MaxMin
{
    internal class MaxMin
    {
        public void Execute()
        {
            var arr = new int[] { 21, 34, 56, 78, 34, 22 };
            var result = Method(arr);

            Console.WriteLine("Array: ");
            foreach (var i in arr)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\nResolved Array: ");
            foreach (var i in result)
            {
                Console.Write($"{i} ");
            }
        }

        private int[] Method(int[] nums)
        {
            int max = nums[0];
            int min = nums[0];
            var maxMin = new int[2];

            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                    max = nums[i];
                else if (nums[i] < min)
                    min = nums[i];
            }

            maxMin[0] = max;
            maxMin[1] = min;
            return maxMin;
        }
    }
}
