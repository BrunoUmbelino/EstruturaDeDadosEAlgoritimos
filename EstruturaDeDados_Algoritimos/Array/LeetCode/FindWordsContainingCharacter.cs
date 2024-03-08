using System.Collections;

namespace EstruturaDeDados_Algoritimos.Array.LeetCode
{
    internal class FindWordsContainingCharacter
    {
        public void Execute()
        {
            var arr = new string[] { "leet", "code" };
            var result = Method(arr, "e");

            Console.WriteLine("Array: ");
            foreach (var i in arr)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\nResolved Array: ");
            foreach (var i in result)
            {
                Console.Write($"{i} ");
            }
        }

        private IList Method(string[] words, string x)
        {
            var arrInd = new List<int>();
            for (var i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(x))
                {
                    arrInd.Add(i);
                }
            }
            return arrInd;
        }
    }
}
