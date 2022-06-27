namespace GithubCopilotProject
{
    public class ShellSort
    {
        public static void ShellSortAlgorithm(int[] input)
        {
            int gap = input.Length / 2;
            while (gap > 0)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    int temp = input[i];
                    int j = i;
                    while (j >= gap && input[j - gap] > temp)
                    {
                        input[j] = input[j - gap];
                        j -= gap;
                    }
                    input[j] = temp;
                }
                gap /= 2;
            }
        }
    }
}
