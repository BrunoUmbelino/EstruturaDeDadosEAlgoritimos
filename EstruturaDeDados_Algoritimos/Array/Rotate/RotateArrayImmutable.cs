namespace EstruturaDeDados_Algoritimos.Array.RotateArray
{
    internal class RotateArrayImmutable
    {
        public void Execute()
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6 };
            var result = RotateArray(arr, "left");

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

        private IEnumerable<int> RotateArray(int[] nums, string direction)
        {
            if (direction.ToLower() == "right")
            {
                int aux = nums[nums.Length - 1];
                for (int i = nums.Length - 1; i >= 0; i--)
                {
                    if (i == 0)
                        nums[i] = aux;
                    else
                        nums[i] = nums[i - 1];
                }
                return nums;
            }
            else if (direction.ToLower() == "left")
            {
                int aux = nums[0];
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i == nums.Length-1)
                        nums[i] = aux;
                    else
                        nums[i] = nums[i + 1];
                }
                return nums;
            }
            else
                throw new ArgumentException();
        }
    }
} 
