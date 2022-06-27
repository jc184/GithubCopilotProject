namespace GithubCopilotProject
{
    public class BucketSort
    {
        public static void BucketSortAlgorithm(int[] array)
        {
            int max = array[0];
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            int bucketSize = (max - min) / array.Length + 1;
            List<int>[] buckets = new List<int>[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                buckets[i] = new List<int>();
            }
            for (int i = 0; i < array.Length; i++)
            {
                int bucketIndex = (array[i] - min) / bucketSize;
                buckets[bucketIndex].Add(array[i]);
            }
            int currentIndex = 0;
            for (int i = 0; i < buckets.Length; i++)
            {
                if (buckets[i].Count > 0)
                {
                    for (int j = 0; j < buckets[i].Count; j++)
                    {
                        array[currentIndex] = buckets[i][j];
                        currentIndex++;
                    }
                }
            }
        }
    }
}
