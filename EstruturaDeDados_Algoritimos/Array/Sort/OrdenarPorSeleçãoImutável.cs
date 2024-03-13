namespace EstruturaDeDados_Algoritimos.Array.Sort
{
    internal class OrdenarPorSeleçãoImutável
    {
        public void Execute()
        {
            var arr = new int[] { 34, 86, 22, 12, 534, 96, 21, 8 };
            var result = Method(arr);

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

        public IList<int> Method(IList<int> arr)
        {
            var _arr = new List<int>(arr);
            var arrOrderAsc = new List<int>();
            
            while (_arr.Count > 0) {
                var min = _arr.Min(i => i);
                arrOrderAsc.Add(min);
                _arr.Remove(min);
            }

            return arrOrderAsc;
        }
    }
}
