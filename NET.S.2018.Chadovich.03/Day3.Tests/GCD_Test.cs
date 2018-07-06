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
        [TestCase(0, 2, ExpectedResult = 2)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(-3, 4, ExpectedResult = 1)]
        [TestCase(-6, -7, ExpectedResult = -1)]
        [TestCase(16, 20, ExpectedResult = 4)]
        [TestCase(16, 20, 28, ExpectedResult = 4)]
        public int Can_Euclid_Of_N_Numbers(params int[] numbers)
        {
            var result = GCD.Euclid(out long delay, numbers);
            Debug.WriteLine($"{nameof(GCD.Euclid)}: {delay}");
            return result;
        }
        
        [TestCase(2)]
        [TestCase()]
        public void Euclid_Throws_ArgumentException(params int[] numbers) =>
            Assert.Throws<ArgumentException>(() => GCD.Euclid(numbers));
        #endregion

        #region Stein Tests
        [TestCase(0x10_000_000, 0x1_000_000, 0x100_000, 0x10_000, 0x1000, 0x100, 0x10, ExpectedResult = 16)]
        [TestCase(0, 2, ExpectedResult = 2)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(-3, 4, ExpectedResult = 1)]
        [TestCase(-6, -7, ExpectedResult = -1)]
        [TestCase(16, 20, ExpectedResult = 4)]
        [TestCase(16, 20, 28, ExpectedResult = 4)]
        public int Can_Stein_Of_N_Numbers(params int[] numbers)
        {
            var result = GCD.Stein(out long delay, numbers);
            Debug.WriteLine($"{nameof(GCD.Stein)}: {delay}");
            return result;
        }
        
        [TestCase(2)]
        [TestCase()]
        public void Stein_Throws_ArgumentException(params int[] numbers) =>
            Assert.Throws<ArgumentException>(() => GCD.Stein(numbers));
        #endregion
    }
}
