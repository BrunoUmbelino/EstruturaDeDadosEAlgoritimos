using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados_Algoritimos.Array.LeetCode
{
    internal class BuildArrayfromPermutation
    {
        public void Execute()
        {
            var arr = new int[] { 0, 2, 1, 5, 3, 4 };
            var result = AAA(arr);

            Console.WriteLine("Array: ");
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\nResolved Array: ");
            foreach (int i in result)
            {
                Console.Write($"{i} ");
            }
        }

        private IEnumerable<int> AAA(int[] nums)
        {
            int[] temp = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
                temp[i] = nums[nums[i]];
            return temp;
        }
    }
}
