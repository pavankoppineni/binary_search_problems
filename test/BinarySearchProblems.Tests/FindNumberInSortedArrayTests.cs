using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinarySearchProblems.Tests
{
    [TestClass]
    public class FindNumberInSortedArrayTests
    {
        [TestMethod]
        public void GivenSortedArrayAndNumberToFind_Find_ReturnsIndexOfNumber()
        {
            //Arrange
            var values = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var number = 5;
            var solution = new FindNumberInSortedArray();

            //Act
            var index = solution.Find(values, number);

            //Assert
            Assert.AreEqual(number, values[index]);
        }
    }
}
