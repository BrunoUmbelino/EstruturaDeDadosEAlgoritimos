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
            var ds = new MyArray(new int[] { 34, 65, 12, 42, 99 });

       
            Console.WriteLine();
            Console.WriteLine(ds.BinarySearch(999));

        }
    }
}