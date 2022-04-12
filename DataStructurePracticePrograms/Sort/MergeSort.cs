namespace DataStructurePracticePrograms.Sort
{
    internal class MergeSort
    {
        private void Sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                //Find middle point
                int mid = (left + right - 1) / 2;

                //Call Sort for first half
                Sort(array, left, mid);

                //Call Sort for second half
                Sort(array, mid + 1, right);

                //Call Merge
                Merge(array, left, mid, right);
            }
        }

        private void Merge(int[] array, int left, int mid, int right)
        {
            //Find length of the sub arrays
            int l = mid - left + 1;
            int r = right - mid;

            //Create temp arrays
            int[] L = new int[l];
            int[] R = new int[r];
            int i, j;

            //copy data to temp array
            for (i = 0; i < l; i++)
                L[i] = array[l + i];
            for (i = 0; i < r; i++)
                R[i] = array[mid + 1 + i];

            //Merge temp arrays

            //initialize index of first and seconf sub arrays

            i = 0;
            j = 0;

            //initialize index of merged subarray
            int k = l;

            while (i < l && j < r)
            {
                if (L[i] <= R[j])
                {
                    array[k] = L[i];
                    i++;
                }
                else
                {
                    array[k] = R[j];
                    j++;
                }
                k++;
            }

            //Copy remaining elements

            while (i < l)
            {
                array[k] = L[i];
                i++;
                k++;
            }
            while (j < r)
            {
                array[k] = R[j];
                j++;
                k++;
            }
        }

        private static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            Console.WriteLine("Given Array");
            printArray(arr);
            MergeSort ob = new MergeSort();
            ob.Sort(arr, 0, arr.Length - 1);
            Console.WriteLine("\nSorted array");
            printArray(arr);
        }
    }
}