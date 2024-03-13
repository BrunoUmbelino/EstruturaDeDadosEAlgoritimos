namespace EstruturaDeDados_Algoritimos.Array.ArrayOperationsUnsorted
{
    internal class MyArray
    {
        private int[] _arr;
        private int capacidadeMaxima;
        private int indexDoUltimoElemento;

        public MyArray(int[] nums)
        {
            _arr = nums;
            capacidadeMaxima = nums.Length;
            indexDoUltimoElemento = nums.Length-1;
        }

        private void DobrarCapacidade()
        {
            var newArr = new int[_arr.Length * 2];
            System.Array.Copy(_arr, newArr, _arr.Length);
            _arr = newArr;
        }

        // O(n)
        // O(1)
        public int LinearSearch(int element)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i] == element)
                    return i;
            }
            return -1;
        }

        //O (log n)
        public int BinarySearch(int element)
        {
            System.Array.Sort(_arr);

            int low = 0;
            int high = _arr.Length - 1;
            
            while (low <= high)
            {
                int mid = low + (low + high) / 2;

                if (_arr[mid] == element)
                    return mid;
                else if (_arr[mid] > element)
                    low = mid - 1;
                else if (_arr[mid] < element)
                    high = mid - 1;
            }
            return -1;
        }

        // O(1)
        // O(1)
        public int[] Insert(int element)
        {
            if (capacidadeMaxima == _arr.Length)
                DobrarCapacidade();

            _arr[indexDoUltimoElemento + 1] = element;
            indexDoUltimoElemento++;

            return _arr;
        }

        // O(n)
        // O(1)
        public int[] Insert(int element, int position)
        {
            if (capacidadeMaxima == _arr.Length)
                DobrarCapacidade();

            for (int i = indexDoUltimoElemento+1; i > position; i--)
            {
                _arr[i] = _arr[i - 1];
            }
            _arr[position] = element;
            return _arr;
        }

        // O(n)
        // O(1)
        public int[] Delete(int element)
        {
            var index = LinearSearch(element);
            if (index == -1) throw new Exception("Elemento não encontrado.");

            for (int i = index; i < _arr.Length -1; i++)
            {
                _arr[i] = _arr[i + 1];
            }
            return _arr;
        }
    }
}
