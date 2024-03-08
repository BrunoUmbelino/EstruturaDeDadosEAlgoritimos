namespace EstruturaDeDados_Algoritimos.Array.Rearrange
{
    internal class RearrangeArray
    {
        public void Execute()
        {
            var arr = new int[] { 1, 3, 2, 1 };
            var result = Rearrange(arr);

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

        private IEnumerable<int> Rearrange(int[] arr)
        {
            System.Array.Sort(arr);
            //for(int i = 0; i <= arr.Length-1; i++)
            //{
            //    var x = System.Array.Find(arr, el=> el == i);
            //    x = x == 0?
            //    arr[i] = x;
            //}

            return arr;
        }


    }
}

