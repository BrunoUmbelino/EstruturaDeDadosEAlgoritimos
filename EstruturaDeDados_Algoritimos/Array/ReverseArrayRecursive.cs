namespace EstruturaDeDados_Algoritimos.Array
{
    internal class ReverseArrayRecursive
    {
        public void Execute()
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine("Array: ");
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }

            ReverseArray(arr, 0, arr.Length-1);

            Console.WriteLine("\nReversed Array: ");
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }
        }

        private void ReverseArray(int[] arr, int start, int end)
        {
            if (start >= end) 
                return;

            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            ReverseArray(arr, start + 1, end - 1);
        }
    }
}
