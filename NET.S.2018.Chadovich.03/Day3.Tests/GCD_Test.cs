using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Day3.Tests
{
    [TestFixture]
    public class GCD_Test
    {
        #region Euclid Tests
        [TestCase(0x10_000_000, 0x1_000_000, 0x100_000, 0x10_000, 0x1000, 0x100, 0x10, ExpectedResult = 16)]
        public int Can_Euclid_Of_N_Numbers(params int[] numbers)
        {
            var result = GCD.Euclid(out long delay, numbers);
            Debug.WriteLine($"{nameof(GCD.Euclid)}: {delay}");
            return result;
        }

        [TestCase(16, 20, ExpectedResult = 4)]
        public int Can_Euclid_Of_2_Numbers(int number1, int number2) =>
            GCD.Euclid(number1, number2);

        [TestCase(16, 20, 28, ExpectedResult = 4)]
        public int Can_Euclid_Of_3_Numbers(int number1, int number2, int number3) =>
            GCD.Euclid(number1, number2, number3);

        [TestCase(2)]
        [TestCase()]
        public void Euclid_Throws_ArgumentException(params int[] numbers) =>
            Assert.Throws<ArgumentException>(() => GCD.Euclid(numbers));
        #endregion

        #region Stein Tests
        [TestCase(0x10_000_000, 0x1_000_000, 0x100_000, 0x10_000, 0x1000, 0x100, 0x10, ExpectedResult = 16)]
        public int Can_Stein_Of_N_Numbers(params int[] numbers)
        {
            var result = GCD.Stein(out long delay, numbers);
            Debug.WriteLine($"{nameof(GCD.Stein)}: {delay}");
            return result;
        }

        [TestCase(16, 20, ExpectedResult = 4)]
        public int Can_Stein_Of_2_Numbers(int number1, int number2) =>
                GCD.Stein(number1, number2);

        [TestCase(16, 20, 28, ExpectedResult = 4)]
        public int Can_Stein_Of_3_Numbers(int number1, int number2, int number3) =>
            GCD.Stein(number1, number2, number3);

        [TestCase(2)]
        [TestCase()]
        public void Stein_Throws_ArgumentException(params int[] numbers) =>
            Assert.Throws<ArgumentException>(() => GCD.Stein(numbers));
        #endregion
    }
}
