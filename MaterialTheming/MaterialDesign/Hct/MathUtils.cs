namespace MaterialTheming.MaterialDesign.HctConversion
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
            return num switch
            {
                < 0 => -1,
                > 0 => 1,
                _ => 0
            };
        }

        /**
         * Sanitizes a degree measure as a floating-point number.
         *
         * @return a degree measure between 0.0 (inclusive) and 360.0 (exclusive).
         */
        public static double SanitizeDegrees(double degrees)
        {
            var singleRotation = degrees % 360;
            if (singleRotation < 0)
                singleRotation += 360;
            return singleRotation;
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
