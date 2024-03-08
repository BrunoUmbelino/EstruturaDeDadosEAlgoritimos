namespace EstruturaDeDados_Algoritimos.Array.LeetCode
{
    internal class FinalValueAfterOperations
    {
        public void Execute()
        {
            var arr = new string[] { "--X", "X++", "X++" };
            var result = Method(arr);

            Console.WriteLine("Array: ");
            foreach (var i in arr)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\nResolved Array: ");
            Console.WriteLine($": {result} ");
        }

        private int Method(string[] operations)
        {
            int x = 0;
            foreach (var op in operations)
            {
                x = op switch
                {
                    "X++" or "++X" => x += 1,
                    "X--" or "--X" => x -= 1,
                    _ => throw new NotImplementedException(),
                };
            }
            return x;
        }
    }
}
