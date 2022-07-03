
namespace GithubCopilotProject
{
    public class RadixSort
    {
        public static void RadixSortAlgorithm(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            int exp = 1;
            while (max / exp > 0)
            {
                int[] output = new int[array.Length];
                int[] bucket = new int[10];
                for (int i = 0; i < array.Length; i++)
                {
                    bucket[(array[i] / exp) % 10]++;
                }
                for (int i = 1; i < 10; i++)
                {
                    bucket[i] += bucket[i - 1];
                }
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    output[bucket[(array[i] / exp) % 10] - 1] = array[i];
                    bucket[(array[i] / exp) % 10]--;
                }
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = output[i];
                }
                exp *= 10;
            }
        }
    }
}
