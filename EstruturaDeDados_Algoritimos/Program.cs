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
            var ds = new MyArray(new int[] { 23, 5, 56, 34, 67, 213, 34 });
            var arr = ds.GetArray();
            var r = ds.MergeSort(arr, 0, arr.Length - 1);

            foreach ( var i in r )
                Console.WriteLine(i);
        }
    }
}