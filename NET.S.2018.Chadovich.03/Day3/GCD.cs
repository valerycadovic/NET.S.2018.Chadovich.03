namespace Day3
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    /// <summary>
    /// Contains methods for working with GCD
    /// </summary>
    public static class GCD
    {
        #region Public API
        /// <summary>
        /// Computing GCD using Euclid's algorithm
        /// </summary>
        /// <param name="number1">first number is required</param>
        /// <param name="number2">second number is required</param>
        /// <param name="numbers">optional parameters</param>
        /// <returns>GCD of n numbers</returns>
        public static int Euclid(int number1, int number2, params int[] numbers)
        {
            int gcd2 = GcdClassic(number1, number2);

            if (numbers.Length == 0)
            {
                return gcd2;
            }
            
            return Find(gcd2, numbers, GcdClassic);
        }

        /// <summary>
        /// Computing GCD using Stein's algorithm
        /// </summary>
        /// <param name="number1">first number is required</param>
        /// <param name="number2">second number is required</param>
        /// <param name="numbers">optional parameters</param>
        /// <returns>GCD of n numbers</returns>
        public static int Stein(int number1, int number2, params int[] numbers)
        {
            int gcd2 = GcdBinary(number1, number2);

            if (numbers.Length == 0)
            {
                return gcd2;
            }

            return Find(gcd2, numbers, GcdBinary);
        }

        /// <summary>
        /// Gets time elapsed to computing
        /// </summary>
        /// <param name="func">function to be computed</param>
        /// <param name="number1">required argument 1</param>
        /// <param name="number2">required argument 2</param>
        /// <param name="numbers">optional arguments</param>
        /// <returns>GCD of n numbers</returns>
        public static long TimeElapsed(Func<int, int, int[], int> func, int number1, int number2, params int[] numbers)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            func(number1, number2, numbers);
            return stopwatch.ElapsedMilliseconds;
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Computes GCD of n numbers
        /// </summary>
        /// <param name="a">start value</param>
        /// <param name="numbers">numbers to be handled</param>
        /// <param name="gcd">searching GCD algorithm</param>
        /// <returns>GCD of n numbers</returns>
        private static int Find(int a, int[] numbers, Func<int, int, int> gcd)
        {
            int FindGcd(int i, int acc) => i == numbers.Length ? acc : FindGcd(i + 1, gcd(acc, numbers[i]));

            return FindGcd(0, a);
        }

        /// <summary>
        /// Search GCD of 2 numbers via Euclid's algorithm
        /// </summary>
        /// <param name="number1">first number</param>
        /// <param name="number2">second number</param>
        /// <returns>GCD of 2 numbers</returns>
        private static int GcdClassic(int number1, int number2)
        {
            if (number1 == number2 || number1 == 0)
            {
                return number2;
            }

            if (number2 == 0)
            {
                return number1;
            }

            int Gcd(int a, int b) => b == 0 ? a : Gcd(b, a % b);

            return Gcd(number1, number2);
        }

        /// <summary>
        /// Search GCD of 2 numbers via Stein's algorithm
        /// </summary>
        /// <param name="number1">first number</param>
        /// <param name="number2">second number</param>
        /// <returns>GCD of 2 numbers</returns>
        private static int GcdBinary(int number1, int number2)
        {
            if (number1 == 0)
            {
                return number2;
            }

            if (number2 == 0 || number1 == number2)
            {
                return number1;
            }

            int Gcd(int a, int b)
            {
                if (a == 1 || b == 1)
                {
                    return 1;
                }

                if ((a & 1) == 0)
                {
                    return ((b & 1) == 0) ? Gcd(a >> 1, b >> 1) << 1 : Gcd(a >> 1, b);
                }
                else
                {
                    return ((b & 1) == 0) ? Gcd(a, b >> 1) : Gcd(b, Math.Abs(a - b));
                }
            }

            return Gcd(number1, number2);
        }
        #endregion
    }
}
