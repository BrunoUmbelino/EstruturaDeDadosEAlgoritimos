namespace EstruturaDeDados_Algoritimos.Array.LeetCode
{
    internal class NumberOfEmployeesWhoMetTarget
    {
        public void Execute()
        {
            var arr = new int[] { 0, 1, 2, 3, 4 };
            var result = Method(arr, 2);

            Console.WriteLine("Array: ");
            foreach (var i in arr)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\nR: ");
            Console.Write($"{result} ");
        }

        private int Method(int[] hours, int target)
        {
            int funcionariosOk = 0;
            for (var i = 0; i < hours.Length; i++) {
                if (hours[i] >= target)
                    funcionariosOk++;
            }
            return funcionariosOk;
        }
    }
}
