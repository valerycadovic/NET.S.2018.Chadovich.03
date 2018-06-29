namespace Day3
{
    using System;

    /// <summary>
    /// Includes a set of basic algorithms
    /// </summary>
    public static class Algorithms
    {
        /// <summary>
        /// Finds a real root of a real number
        /// </summary>
        /// <param name="number">preset number</param>
        /// <param name="power">root degree</param>
        /// <param name="precision">accuracy of measurement</param>
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
    }
}
