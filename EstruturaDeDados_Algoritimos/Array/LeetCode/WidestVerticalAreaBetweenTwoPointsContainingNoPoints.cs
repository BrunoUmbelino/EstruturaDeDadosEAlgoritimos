using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados_Algoritimos.Array.LeetCode
{
    internal class WidestVerticalAreaBetweenTwoPointsContainingNoPoints
    {
        public void Execute()
        {
            var arr = new int[][] { 
                new int[]{ 8, 7 }, 
                new int[] { 9, 9 }, 
                new int[] { 7, 4 }, 
                new int[] { 9, 7 } };
            var result = Method(arr);

            Console.WriteLine("Array: ");
            foreach (var i in arr)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\nR: ");
            Console.Write($"{result} ");
        }

        private int Method(int[][] points)
        {
            int[] xPoints = new int[points.GetLength(0)];
            for(int i = 0; i < points.GetLength(0); i++)
                xPoints[i] = points[i][0];

            System.Array.Sort(xPoints);

            int max = 0;
            for(int i = 1; i < xPoints.Length; i++)
            {
                var diff = xPoints[i] - xPoints[i - 1]; 
                if (diff > max)
                    max = diff;
            }
            return max;
        }
    }
}
