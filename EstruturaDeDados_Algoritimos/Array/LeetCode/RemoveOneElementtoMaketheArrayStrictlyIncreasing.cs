namespace EstruturaDeDados_Algoritimos.Array.test
{
    internal class RemoveOneElementtoMaketheArrayStrictlyIncreasing
    {
        public void Execute()
        {
            var arr = new int[] { 2, 3, 1, 2 };
            var result = CanBeIncreasing2(arr);

            Console.WriteLine("Array: ");
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine($"\nR: {result}");
        }

        // Melhorar o desempenho
        private bool CanBeIncreasing(int[] nums)
        {
            int control = 0;

            while (control < nums.Length)
            {
                // monta o arary temporário
                var tempArr = new int[nums.Length - 1];
                int indexTempArr = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (control == i)
                        continue;

                    tempArr[indexTempArr] = nums[i];
                    indexTempArr++;
                }
                control++;

                // verificar se o array temporário é strictly
                bool arrIsSorted = true;
                for (int i = 1; i < tempArr.Length; i++)
                {
                    if (tempArr[i] <= tempArr[i - 1])
                    {
                        arrIsSorted = false;
                        break;
                    }

                    tempArr[indexTempArr] = nums[i];
                    indexTempArr++;
                }

                if (arrIsSorted == true)
                    return true;
            }

            return false;
        }

        private bool CanBeIncreasing2(int[] nums)
        {
            int control = 0;

            while (control < nums.Length)
            {
                var tempArr = new int[nums.Length - 1];
                int indexTempArr = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (control == i)
                        continue;

                    tempArr[indexTempArr] = nums[i];
                    indexTempArr++;
                }
                control++;


            }

            return false;
        }
    }
}

