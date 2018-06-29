using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Day3.Tests
{
    [TestFixture]
    public class GCD_Test
    {
        [TestCase(16, 20, ExpectedResult = 4)]
        [TestCase(16, 20, 28, ExpectedResult = 4)]
        [TestCase(0x10_000_000, 0x1_000_000, 0x100_000, 0x10_000, 0x1000, 0x100, 0x10, ExpectedResult = 16)]
        public int Can_Euclid(int number1, int number2, params int[] numbers) =>
            GCD.Euclid(number1, number2, numbers);

        [TestCase(16, 20, ExpectedResult = 4)]
        [TestCase(16, 20, 28, ExpectedResult = 4)]
        [TestCase(0x10_000_000, 0x1_000_000, 0x100_000, 0x10_000, 0x1000, 0x100, 0x10, ExpectedResult = 16)]
        public int Can_Stein(int number1, int number2, params int[] numbers) =>
            GCD.Euclid(number1, number2, numbers);
    }
}
