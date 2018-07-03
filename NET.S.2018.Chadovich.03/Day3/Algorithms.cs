namespace Day3
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    /// <summary>
    /// Includes a set of basic algorithms
    /// </summary>
    public static class Algorithms
    {
        #region Public API
        /// <summary>
        /// Finds a real root of a real number
        /// </summary>
        /// <param name="number">preset number</param>
        /// <param name="power">root degree</param>
        /// <param name="precision">accuracy of measurement</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when:
        ///     precision is out of range between 0 and 1
        ///     exponent is negative
        ///     exponent is even if number is negative
        /// </exception>
        /// <returns>nth root as real number</returns>
        public static double RealRoot(double number, int power, double precision)
        {
            if (precision >= 1 || precision <= 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(precision)} must be in range (0, 1)");
            }

            if (power == 1)
            {
                return number;
            }

            if (power <= 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(power)} must be positive to work with real numbers only");
            }

            if (power % 2 == 0 && number < 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(number)} will be non-real through the current operation");
            }

            double current = 1;
            double next = (((power - 1) * current) + (number / Math.Pow(current, power - 1))) / power;

            do
            {
                current = next;
                next = (((power - 1) * current) + (number / Math.Pow(current, power - 1))) / power;
            }
            while (Math.Abs(next - current) > precision);

            return next;
        }

        /// <summary>
        /// Looks for the next bigger number which consists of digits of preset number
        /// </summary>
        /// <param name="number">Preset number</param>
        /// <param name="delay">Returns milliseconds elapse while method working</param>
        /// <exception cref="ArgumentOutOfRangeException">Throws when number is negative</exception>
        /// <returns>Result number if it exists or null if preset number is already the biggest</returns>
        public static int? FindNextBiggerNumber(int number, out long delay)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(number)} must be positive!");
            }

            Stopwatch stopwatch = Stopwatch.StartNew();

            if (number <= 11)
            {
                delay = stopwatch.ElapsedMilliseconds;
                return null;
            }

            int[] digits = ConvertNumberToDigitsArray(number);
            int? index = FindStartSortIndex(digits);

            if (index == null)
            {
                delay = stopwatch.ElapsedMilliseconds;
                return null;
            }

            int start = index.Value;
            
            var result = MapNumber(digits, start);

            delay = stopwatch.ElapsedMilliseconds;
            return result;
        }
        #endregion

        #region Private Utility Methods for FindNextBiggerNumber
        /// <summary>
        /// Sorts required part of a number to get the next bigger one
        /// </summary>
        /// <param name="array">Digits array of a number</param>
        /// <param name="start">Index which is start to sorting</param>
        /// <returns>The next bigger number</returns>
        private static int? MapNumber(int[] array, int start)
        {
            if (start == 0)
            {
                return null;
            }

            Swap(ref array[start], ref array[start - 1]);
            Array.Sort(array, start, array.Length - start);

            return ConvertDigitsArrayToNumber(array);
        }

        /// <summary>
        /// Converts digits array to number
        /// </summary>
        /// <param name="array">Array to convert</param>
        /// <returns>Converted number</returns>
        private static int ConvertDigitsArrayToNumber(int[] array)
        {
            var a = int.Parse(string.Join(string.Empty, array));
            return a;
        }

        /// <summary>
        /// Converts number to digits array
        /// </summary>
        /// <param name="number">Number to convert</param>
        /// <returns>Converted digits array</returns>
        private static int[] ConvertNumberToDigitsArray(int number)
        {
            var temp = number.ToString();
            List<int> digits = new List<int>();

            foreach (var i in temp)
            {
                digits.Add(int.Parse(i.ToString()));
            }

            return digits.ToArray();
        }

        /// <summary>
        /// Looking for the index to start sorting
        /// </summary>
        /// <param name="array">array where to search</param>
        /// <returns>Either required index or null if array is sorted descending</returns>
        private static int? FindStartSortIndex(int[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                if (array[i] > array[i - 1])
                {
                    return i;
                }
            }

            return null;
        }
        #endregion

        #region Other Private Methods

        /// <summary>
        /// Swaps two objects
        /// </summary>
        /// <typeparam name="T">type of objects</typeparam>
        /// <param name="a">first object</param>
        /// <param name="b">second object</param>
        private static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        #endregion
    }
}
