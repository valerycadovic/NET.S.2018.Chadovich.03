namespace Day3.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class Algorithms_Test
    {
        #region Root Tests
        [TestCase(1, 5, 0.000_001, 1)]
        [TestCase(8, 3, 0.0001, 2)]
        [TestCase(0.001, 3, 0.0001, 0.1)]
        [TestCase(0.041_006_25, 4, 0.0001, 0.45)]
        [TestCase(0.027_9936, 7, 0.0001, 0.6)]
        [TestCase(-0.008, 3, 0.1, -0.2)]
        [TestCase(0.004_241_979, 9, 0.000_000_01, 0.545)]
        [TestCase(0.0081, 4, 0.1,  0.3)]
        public void Can_Root_Precision(double number, int power, double precision, double almostResult) =>
            Assert.AreEqual(Algorithms.RealRoot(number, power, precision), almostResult, precision);

        [TestCase(-0.01, 2, 0.0001)]
        [TestCase(0.001, -2, 0.0001)]
        [TestCase(0.01, 2, -1)]
        public void RealRoot_Throws_ArgumentOutOfRangeException(double number, int power, double precision) =>
            Assert.Throws<ArgumentOutOfRangeException>(() => Algorithms.RealRoot(number, power, precision));
        #endregion

        #region FindNextBiggestNumber Tests
        [TestCase(12, ExpectedResult = 21)]
        [TestCase(513, ExpectedResult = 531)]
        [TestCase(2017, ExpectedResult = 2071)]
        [TestCase(414, ExpectedResult = 441)]
        [TestCase(144, ExpectedResult = 414)]
        [TestCase(1234321, ExpectedResult = 1241233)]
        [TestCase(1234126, ExpectedResult = 1234162)]
        [TestCase(3456432, ExpectedResult = 3462345)]
        [TestCase(10, ExpectedResult = null)]
        [TestCase(20, ExpectedResult = null)]
        public int? Can_FindNextBiggestNumber(int number) =>
            Algorithms.FindNextBiggerNumber(number, out _);

        [TestCase(-15)]
        public void FindNextBiggestNumber(int number) =>
            Assert.Throws<ArgumentOutOfRangeException>(() => Algorithms.FindNextBiggerNumber(number, out _));
        #endregion
    }
}
