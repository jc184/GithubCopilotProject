using static GithubCopilotProject.InsertionSort;
using static GithubCopilotProject.SelectionSort;
using static GithubCopilotProject.MergeSort;
using static GithubCopilotProject.QuickSort;
using static GithubCopilotProject.HeapSort;
using static GithubCopilotProject.ShellSort;
using static GithubCopilotProject.CombSort;
using static GithubCopilotProject.BucketSort;
using static GithubCopilotProject.BubbleSort;
using static GithubCopilotProject.RadixSort;

namespace GithubCopilotProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 1, 4, 3, 2, 5, 8, 7, 9, 6, 10 };
            RadixSortAlgorithm(input);
            foreach (int i in input)
            {
                Console.WriteLine(i);
            }
        }
    }
}