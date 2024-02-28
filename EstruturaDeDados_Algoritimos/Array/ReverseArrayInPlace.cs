using System.Collections.Generic;

namespace EstruturaDeDados_Algoritimos.Array
{
    internal class ReverseArrayInPlace
    {
        public void Execute()
        {
            var arr = new int[] { 3, 4, 5, 8, 10};

            Console.WriteLine("Array: ");
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }

            var result = ReverseArray(arr);

            Console.WriteLine("\nReversed Array: ");
            foreach (int i in result)
            {
                Console.Write($"{i} ");
            }
        }

        private int[] ReverseArray(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                var start = i;
                var end = array.Length - 1 - i;
                if (start > end)
                {
                    var temp = array[start];
                    array[start] = array[end];
                    array[end] = temp;
                }
            }
            
            return array;
        }
    }
}
