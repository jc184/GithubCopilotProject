using GithubCopilotProject;

namespace SortingAlgorithmsTests
{
    public class HeapSortTest
    {
        [Fact]
        public void HeapSortAlgorithmTest()
        {
            //Arrange
            int[] array = new int[] { 5, 4, 3, 2, 1 };
            //Act
            HeapSort.HeapSortAlgorithm(array);
            //Assert
            Assert.Equal(1, array[0]);
            Assert.Equal(2, array[1]);
            Assert.Equal(3, array[2]);
            Assert.Equal(4, array[3]);
            Assert.Equal(5, array[4]);
        }
    }
}
