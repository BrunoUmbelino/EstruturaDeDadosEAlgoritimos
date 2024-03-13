using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados_Algoritimos.Array.LeetCode
{
    internal class RichestCustomerWealth
    {
        public void Execute()
        {
            var arr = new int[][] {
                new int[]{ 1,2,3 },
                new int[] { 3,2,1 },
               };
            var result = Method(arr);

            Console.WriteLine("Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write($"{arr[i][j]} ");
                }
                Console.Write("\n");
            }

            Console.Write($"R: {result} ");
        }

        private int Method(int[][] accounts)
        {
            int maxWealth = 0;
            for(int i = 0; i < accounts.Length; i++)
            {
                int wealth = accounts[i].Sum();
                if (wealth > maxWealth)
                    maxWealth = wealth;
            }
            return maxWealth;
        }
    }
}
