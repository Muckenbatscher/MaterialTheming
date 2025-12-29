using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes.MaterialDesign.HctConversion
{
    internal class MathUtils
    {
        /**
         * The signum function.
         *
         * @return 1 if num > 0, -1 if num < 0, and 0 if num = 0
         */
        public static int Signum(double num)
        {
            if (num < 0)
            {
                return -1;
            }
            else if (num == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        /**
         * The linear interpolation function.
         *
         * @return start if amount = 0 and stop if amount = 1
         */
        public static double Lerp(double start, double stop, double amount)
        {
            return (1.0 - amount) * start + amount * stop;
        }

        /**
         * Clamps an integer between two integers.
         *
         * @return input when min <= input <= max, and either min or max otherwise.
         */
        public static int ClampInt(int min, int max, int input)
        {
            if (input < min)
            {
                return min;
            }
            else if (input > max)
            {
                return max;
            }

            return input;
        }

        /**
         * Clamps an integer between two floating-point numbers.
         *
         * @return input when min <= input <= max, and either min or max otherwise.
         */
        public static double ClampDouble(double min, double max, double input)
        {
            if (input < min)
            {
                return min;
            }
            else if (input > max)
            {
                return max;
            }

            return input;
        }

        /**
         * Sanitizes a degree measure as a floating-point number.
         *
         * @return a degree measure between 0.0 (inclusive) and 360.0 (exclusive).
         */
        public static double SanitizeDegreesDouble(double degrees)
        {
            degrees = degrees % 360.0;
            if (degrees < 0)
            {
                degrees = degrees + 360.0;
            }
            return degrees;
        }

        /** Multiplies a 1x3 row vector with a 3x3 matrix. */
        public static double[] MatrixMultiply(double[] row, double[][] matrix)
        {
            double a = row[0] * matrix[0][0] + row[1] * matrix[0][1] + row[2] * matrix[0][2];
            double b = row[0] * matrix[1][0] + row[1] * matrix[1][1] + row[2] * matrix[1][2];
            double c = row[0] * matrix[2][0] + row[1] * matrix[2][1] + row[2] * matrix[2][2];
            return new double[] { a, b, c };
        }
    }
}
