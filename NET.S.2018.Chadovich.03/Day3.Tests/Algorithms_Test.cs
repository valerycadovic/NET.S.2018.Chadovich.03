namespace Day3.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class Algorithms_Test
    {
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
    }
}
