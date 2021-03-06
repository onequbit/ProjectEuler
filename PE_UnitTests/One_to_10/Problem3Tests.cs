using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler;

namespace PE_UnitTests.One_to_10
{
    [TestClass]
    public class Problem3Tests
    {
        

        [TestMethod]
        public void TestMethod1()
        {
            long number = 13195;
            int expectedCount = 4;
            // Arrange
            var unitUnderTest = new Problem3(number);
            int result = unitUnderTest.PrimeFactors.Count;
            // Assert
            Assert.IsTrue(result == expectedCount,
                $"{number} should have {expectedCount} factors, {result} returned");

            number = 60;
            expectedCount = 3;
            // Arrange
            unitUnderTest = new Problem3(number);
            result = unitUnderTest.PrimeFactors.Count;
            // Assert
            Assert.IsTrue(result == expectedCount,
                $"{number} should have {expectedCount} factors, {result} returned");

        }

    }
}
