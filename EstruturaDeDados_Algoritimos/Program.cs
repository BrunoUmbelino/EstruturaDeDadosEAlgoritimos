using EstruturaDeDados_Algoritimos.Array.ArrayOperationsUnsorted;
using EstruturaDeDados_Algoritimos.Array.LeetCode;
using EstruturaDeDados_Algoritimos.Array.RotateArray;
using EstruturaDeDados_Algoritimos.Array.Sort;

namespace EstruturaDeDados_Algoritimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ds = new MyArray(new int[] { 34, 65, 12, 42, 99, 1, 0 ,434, 56, 234, 76, 23, 76 });
            var r = ds.InsertionSort();
       
            foreach (var d in r)
            {
                Console.WriteLine(d);
            }
        }
    }
}