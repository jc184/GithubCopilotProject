
namespace GithubCopilotProject
{
    public class QuickSort
    {
        public static void QuickSortAlgorithm(int[] input)
        {
            QuickSortAlgorithm(input, 0, input.Length - 1);
        }
        private static void QuickSortAlgorithm(int[] input, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(input, left, right);
                QuickSortAlgorithm(input, left, pivot - 1);
                QuickSortAlgorithm(input, pivot + 1, right);
            }
        }
        private static int Partition(int[] input, int left, int right)
        {
            int pivot = input[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (input[j] <= pivot)
                {
                    i++;
                    int temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;
                }
            }
            int temp2 = input[i + 1];
            input[i + 1] = input[right];
            input[right] = temp2;
            return i + 1;
        }
    }
}
