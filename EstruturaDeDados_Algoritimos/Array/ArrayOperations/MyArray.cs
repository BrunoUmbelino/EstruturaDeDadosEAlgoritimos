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
            indexDoUltimoElemento = nums.Length - 1;
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

        // O(log n)
        // O(1)
        public int BinarySearch(int element)
        {
            System.Array.Sort(_arr);

            int fisrt = 0;
            int last = _arr.Length - 1;

            while (fisrt <= last)
            {
                int mid = fisrt + (fisrt + last) / 2;

                if (_arr[mid] == element)
                    return mid;
                else if (_arr[mid] > element)
                    fisrt = mid - 1;
                else if (_arr[mid] < element)
                    last = mid - 1;
            }
            return -1;
        }

        // O(log n)
        // O(1)
        public int TernarySearch(int target)
        {
            System.Array.Sort(_arr);

            int first = 0;
            int last = _arr.Length - 1;

            while (first <= last)
            {
                int mid1 = first + (last - first) / 3;
                int mid2 = first + 2 * (last - first) / 3;

                if (target == _arr[mid1]) return mid1;
                else if (target == _arr[mid2]) return mid2;
                else if (target < _arr[mid1]) last = mid1 - 1;
                else if (target > _arr[mid2]) first = mid2 + 1;
                else
                {
                    first = mid1 + 1;
                    last = mid2 - 1;
                }
            }
            return -1;
        }

        // O (N²)
        // O (1)
        public int[] SelectionSort()
        {
            for (int atual = 0; atual < _arr.Length; atual++)
            {
                var min_index = atual;
                for (int j = atual + 1; j < _arr.Length; j++)
                {
                    if (_arr[j] < _arr[min_index])
                        min_index = j;
                }

                (_arr[min_index], _arr[atual]) = (_arr[atual], _arr[min_index]);
            }
            return _arr;
        }

        // O(N²)
        // O(1)
        public int[] BubleSort()
        {
            for (int atual = 0; atual < _arr.Length; atual++)
            {
                bool swapped = false;
                for (int comparador = 0;  comparador < _arr.Length - atual -1;  comparador++)
                {
                    if (_arr[comparador] > _arr[comparador + 1])
                    {
                        (_arr[comparador], _arr[comparador + 1]) = (_arr[comparador + 1], _arr[comparador]);
                        swapped = true;
                    }
                }
                if (swapped == false) break;
            }

            return _arr;
        }

        // O(n²)
        // O(1)
        public int[] InsertionSort()
        {
            for (int i = 1; i < _arr.Length; i++)
            {
                if (_arr[i] < _arr[i - 1])
                {
                    int j = i;
                    while (j > 0 && _arr[j] < _arr[j - 1])
                    {
                        (_arr[j], _arr[j - 1]) = (_arr[j - 1], _arr[j]);
                        j--;
                    }
                }
            }

            return _arr;
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

            for (int i = indexDoUltimoElemento + 1; i > position; i--)
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

            for (int i = index; i < _arr.Length - 1; i++)
            {
                _arr[i] = _arr[i + 1];
            }
            return _arr;
        }

        private void DobrarCapacidade()
        {
            var newArr = new int[_arr.Length * 2];
            System.Array.Copy(_arr, newArr, _arr.Length);
            _arr = newArr;
        }
    }
}
