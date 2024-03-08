using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados_Algoritimos.Array.LeetCode
{
    internal class RemoveElement
    {
        public void Execute()
        {
            var nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            var result = x(nums, 2);

            Console.WriteLine("Array: ");
            foreach (int i in nums)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n" + result);
        }

        private int x(int[] nums, int val)
        {
            int u = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[u] = nums[i];
                    u++;
                }
            }
            return u;
        }
    }
}
