
namespace GithubCopilotProject
{
    public class MergeSort
    {
        public static void MergeSortAlgorithm(int[] array)
        {
            if (array.Length > 1)
            {
                int mid = array.Length / 2;
                int[] left = new int[mid];
                int[] right = new int[array.Length - mid];

                for (int i = 0; i < mid; i++)
                {
                    left[i] = array[i];
                }

                for (int i = mid; i < array.Length; i++)
                {
                    right[i - mid] = array[i];
                }

                MergeSortAlgorithm(left);
                MergeSortAlgorithm(right);

                int iLeft = 0;
                int iRight = 0;
                int iArray = 0;

                while (iLeft < left.Length && iRight < right.Length)
                {
                    if (left[iLeft] <= right[iRight])
                    {
                        array[iArray] = left[iLeft];
                        iLeft++;
                    }
                    else
                    {
                        array[iArray] = right[iRight];
                        iRight++;
                    }
                    iArray++;
                }

                while (iLeft < left.Length)
                {
                    array[iArray] = left[iLeft];
                    iLeft++;
                    iArray++;
                }

                while (iRight < right.Length)
                {
                    array[iArray] = right[iRight];
                    iRight++;
                    iArray++;
                }
            }
        }
    }

}
