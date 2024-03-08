using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados_Algoritimos.Array.LeetCode
{
    internal class ShuffleTheArray
    {
        public void Execute()
        {
            var arr = new int[] { 2, 5, 1, 3, 4, 7 };
            var result = Method(arr, 3);

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

        private int[] Method(int[] nums, int n)
        {
            int a = 0;
            int b = n;
            var shuffleArr = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                {
                    shuffleArr[i] = nums[a];
                    a++;
                }
                else
                {
                    shuffleArr[i] = nums[b];
                    b++;
                }
            }
            return shuffleArr;
        }
    }
}
