namespace Day3
{
    using System;
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
        /// <param name="number1">first number</param>
        /// <param name="number2">second number</param>
        /// <returns>GCD of 2 numbers</returns>
        public static int Euclid(int number1, int number2)
        {
            return Find(GcdClassic, number1, number2);
        }

        /// <summary>
        /// Computing GCD using Euclid's algorithm
        /// </summary>
        /// <param name="delay">Returns milliseconds elapse while method working</param>
        /// <param name="number1">first number</param>
        /// <param name="number2">second number</param>
        /// <returns>GCD of n numbers</returns>
        public static int Euclid(out long delay, int number1, int number2)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            var result = Euclid(number1, number2);
            delay = stopwatch.ElapsedMilliseconds;
            return result;
        }

        /// <summary>
        /// Computing GCD using Euclid's algorithm
        /// </summary>
        /// <param name="number1">first number</param>
        /// <param name="number2">second number</param>
        /// <param name="number3">third number</param>
        /// <returns>GCD of 3 numbers</returns>
        public static int Euclid(int number1, int number2, int number3)
        {
            return Find(GcdClassic, number1, number2, number3);
        }

        /// <summary>
        /// Computing GCD using Euclid's algorithm
        /// </summary>
        /// <param name="delay">Returns milliseconds elapse while method working</param>
        /// <param name="number1">first number</param>
        /// <param name="number2">second number</param>
        /// <param name="number3">third number</param>
        /// <returns>GCD of n numbers</returns>
        public static int Euclid(out long delay, int number1, int number2, int number3)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            var result = Stein(number1, number2, number3);
            delay = stopwatch.ElapsedMilliseconds;
            return result;
        }

        /// <summary>
        /// Computing GCD using Euclid's algorithm
        /// </summary>
        /// <param name="numbers">optional parameters</param>
        /// <exception cref="ArgumentException">
        /// Throws when count of parameters is less than 2
        /// </exception>
        /// <returns>GCD of n numbers</returns>
        public static int Euclid(params int[] numbers)
        {
            if (numbers.Length < 2)
            {
                throw new ArgumentException($"{nameof(Euclid)}: {nameof(numbers.Length)} must be more than two");
            }

            return Find(GcdClassic, numbers);
        }

        /// <summary>
        /// Computing GCD using Stein's algorithm
        /// </summary>
        /// <param name="number1">first number</param>
        /// <param name="number2">second number</param>
        /// <returns>GCD of 2 numbers</returns>
        public static int Stein(int number1, int number2)
        {
            return Find(GcdBinary, number1, number2);
        }

        /// <summary>
        /// Computing GCD using Stein's algorithm
        /// </summary>
        /// <param name="delay">Returns milliseconds elapse while method working</param>
        /// <param name="number1">first number</param>
        /// <param name="number2">second number</param>
        /// <returns>GCD of n numbers</returns>
        public static int Stein(out long delay, int number1, int number2)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            var result = Stein(number1, number2);
            delay = stopwatch.ElapsedMilliseconds;
            return result;
        }

        /// <summary>
        /// Computing GCD using Stein's algorithm
        /// </summary>
        /// <param name="number1">first number</param>
        /// <param name="number2">second number</param>
        /// <param name="number3">third number</param>
        /// <returns>GCD of 3 numbers</returns>
        public static int Stein(int number1, int number2, int number3)
        {
            return Find(GcdClassic, number1, number2, number3);
        }

        /// <summary>
        /// Computing GCD using Stein's algorithm
        /// </summary>
        /// <param name="delay">Returns milliseconds elapse while method working</param>
        /// <param name="number1">first number</param>
        /// <param name="number2">second number</param>
        /// <param name="number3">third number</param>
        /// <returns>GCD of n numbers</returns>
        public static int Stein(out long delay, int number1, int number2, int number3)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            var result = Stein(number1, number2, number3);
            delay = stopwatch.ElapsedMilliseconds;
            return result;
        }

        /// <summary>
        /// Computing GCD using Stein's algorithm
        /// </summary>
        /// <param name="numbers">optional parameters</param>
        /// <exception cref="ArgumentException">
        /// Throws when count of parameters is less than 2
        /// </exception>
        /// <returns>GCD of n numbers</returns>
        public static int Stein(params int[] numbers)
        {
            if (numbers.Length < 2)
            {
                throw new ArgumentException($"{nameof(Euclid)}: {nameof(numbers.Length)} must be more than two");
            }

            return Find(GcdBinary, numbers);
        }
        
        /// <summary>
        /// Computing GCD using Stein's algorithm
        /// </summary>
        /// <param name="delay">Returns milliseconds elapse while method working</param>
        /// <param name="numbers">optional arguments</param>
        /// <returns>GCD of n numbers</returns>
        public static int Stein(out long delay, params int[] numbers)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            var result = Stein(numbers);
            delay = stopwatch.ElapsedMilliseconds;
            return result;
        }

        /// <summary>
        /// Computing GCD using Euclid's algorithm
        /// </summary>
        /// <param name="delay">Returns milliseconds elapse while method working</param>
        /// <param name="numbers">optional arguments</param>
        /// <returns>GCD of n numbers</returns>
        public static int Euclid(out long delay, params int[] numbers)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            var result = Euclid(numbers);
            delay = stopwatch.ElapsedMilliseconds;
            return result;
        }
        #endregion

        #region Private Methods
        /// <summary>
-       /// Computes GCD of n numbers
-       /// </summary>
-       /// <param name="numbers">numbers to be handled</param>
-       /// <param name="gcd">searching GCD algorithm</param>
-       /// <returns>GCD of n numbers</returns>
-       private static int Find(Func<int, int, int> gcd, params int[] numbers)
-       {
-           int FindGcd(int i, int acc) => i == numbers.Length ? acc : FindGcd(i + 1, gcd(acc, numbers[i]));
-
-           return FindGcd(0, 0);
-       }
            
        /// <summary>
-       /// Computes GCD of 2 numbers
-       /// </summary>
-       /// <param name="numbers">numbers to be handled</param>
-       /// <param name="gcd">searching GCD algorithm</param>
-       /// <returns>GCD of 2 numbers</returns>
-       private static int Find(Func<int, int, int> gcd, int number1, int number2) => gcd(number1, number2);
        
        /// <summary>
-       /// Computes GCD of 3 numbers
-       /// </summary>
-       /// <param name="numbers">numbers to be handled</param>
-       /// <param name="gcd">searching GCD algorithm</param>
-       /// <returns>GCD of 3 numbers</returns>
-       private static int Find(Func<int, int, int> gcd, int number1, int number2, int number3) 
            => gcd(number1, gcd(number2, number3));
        
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
