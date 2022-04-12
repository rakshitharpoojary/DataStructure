namespace DataStructurePracticePrograms.Sort
{
    internal class QuickSort
    {
        private void Sort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);

                Sort(array, low, pi - 1);
                Sort(array, pi + 1, high);
            }
        }

        private int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];

            int i = low - 1;

            for (int j = low; j <= high - 1; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }
            i++;
            Swap(array, i, high);
            return i;
        }

        private void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        private void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void Main(string[] args)
        {
            QuickSort quickSort = new QuickSort();

            int[] array = { 10, 80, 30, 90, 40, 50, 70 };

            quickSort.Sort(array, 0, array.Length - 1);

            quickSort.Print(array);

            Console.ReadLine();
        }
    }
}