namespace GithubCopilotProject
{
    public class HeapSort
    {
        public static void HeapSortAlgorithm(int[] input)
        {
            BuildHeap(input);
            for (int i = input.Length - 1; i > 0; i--)
            {
                int temp = input[0];
                input[0] = input[i];
                input[i] = temp;
                Heapify(input, 0, i - 1);
            }
        }
        private static void BuildHeap(int[] input)
        {
            for (int i = input.Length / 2 - 1; i >= 0; i--)
            {
                Heapify(input, i, input.Length - 1);
            }
        }
        private static void Heapify(int[] input, int i, int heapSize)
        {
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            int largest = i;
            if (left <= heapSize && input[left] > input[largest])
            {
                largest = left;
            }
            if (right <= heapSize && input[right] > input[largest])
            {
                largest = right;
            }
            if (largest != i)
            {
                int temp = input[i];
                input[i] = input[largest];
                input[largest] = temp;
                Heapify(input, largest, heapSize);
            }
        }
    }
}
