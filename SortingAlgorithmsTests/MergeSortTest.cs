using GithubCopilotProject;

namespace SortingAlgorithmsTests
{
    public class MergeSortTest
    {
        [Fact]
        public void MergeSortAlgorithmTest()
        {
            //Arrange
            int[] array = new int[] { 5, 4, 3, 2, 1 };
            //Act
            MergeSort.MergeSortAlgorithm(array);
            //Assert
            Assert.Equal(1, array[0]);
            Assert.Equal(2, array[1]);
            Assert.Equal(3, array[2]);
            Assert.Equal(4, array[3]);
            Assert.Equal(5, array[4]);
        }
    }
}
