namespace EstruturaDeDados_Algoritimos.Array.ReverseArray
{
    internal class ReverseArrayImmutable
    {
        public void Execute()
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6 };
            var result = ReverseArray(arr);

            Console.WriteLine("Array: ");
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\nReversed Array: ");
            foreach (int i in result)
            {
                Console.Write($"{i} ");
            }
        }

        public int[] ReverseArray(int[] array)
        {
            int[] reversedArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[i] = array[array.Length - 1 - i];
            }

            return reversedArray;
        }
    }
}
