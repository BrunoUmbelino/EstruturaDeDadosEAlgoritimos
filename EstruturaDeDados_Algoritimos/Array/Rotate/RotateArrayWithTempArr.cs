namespace EstruturaDeDados_Algoritimos.Array.RotateArray
{
    internal class RotateArrayImmutable
    {
        public void Execute()
        {
            var arr = new int[,] { { 8, 7 }, { 9, 9 }, { 7, 4 }, { 9, 7 } };
            var result = Method(arr);

            Console.WriteLine("Array: ");
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\nResult: ");
            Console.Write($"{result} ");
        }

        private int Method(int[,] points)
        {
            var widthArr = new int[points.Length];
            for (int i = 0; i < points.Length; i++) {
                widthArr[i] = points[i, 0];
            }
            return widthArr.FirstOrDefault();
        }
    }
}
