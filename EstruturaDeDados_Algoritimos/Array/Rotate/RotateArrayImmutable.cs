namespace EstruturaDeDados_Algoritimos.Array.RotateArray
{
    internal class RotateArrayImmutable
    {
        public void Execute()
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6 };
            var result = RotateArray(arr);

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

        private IEnumerable<int> RotateArray(int[] arr)
        {
            var reversedArr = new int[arr.Length];
            var tempEnd = arr[arr.Length - 1];

            for (int i = arr.Length - 1; i > 0; i--)
                reversedArr[i] = arr[i - 1];
            arr[0] = tempEnd;

            return reversedArr;
        }
    }
}
