using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinarySearchProblems.Tests
{
    [TestClass]
    public class FindNumberInSortedArrayV1Tests
    {
        [TestMethod]
        public void GivenSortedArrayAndNumberToFind_Find_ReturnsIndexOfNumber()
        {
            //Arrange
            var values = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var number = 5;
            var solution = new FindNumberInSortedArrayV1();

            //Act
            var index = solution.Find(values, number);

            //Assert
            Assert.AreEqual(number, values[index]);
        }
    }
}
