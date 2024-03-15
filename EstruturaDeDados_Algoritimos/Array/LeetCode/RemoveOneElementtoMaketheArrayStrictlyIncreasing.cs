namespace EstruturaDeDados_Algoritimos.Array.test
{
    internal class RemoveOneElementtoMaketheArrayStrictlyIncreasing
    {
        public void Execute()
        {
            var arr = new int[] { 512, 867, 904, 997, 403 };
            var result = CanBeIncreasing(arr);

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
                bool thisArrIsStrictly = true;
                for (int i = 1; i < tempArr.Length; i++)
                {
                    if (tempArr[i] <= tempArr[i - 1])
                    {
                        thisArrIsStrictly = false;
                        break;
                    }
                }

                if (thisArrIsStrictly == true)
                    return true;
            }

            return false;
        }
    }
}

