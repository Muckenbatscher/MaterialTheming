namespace MaterialTheming.MaterialDesign.HctConversion
{
    internal class MathUtils
    {
        /// <summary>
        /// The signum function.
        /// </summary>
        /// <returns>1 if num &gt; 0, -1 if num &lt; 0, and 0 if num = 0</returns>
        public static int Signum(double num)
        {
            return num switch
            {
                < 0 => -1,
                > 0 => 1,
                _ => 0
            };
        }

        /// <summary>
        /// Sanitizes a degree measured as a floating-point number. 
        /// To only contain less than one rotation and to be positive.
        /// </summary>
        /// <param name="degrees">The degrees to be sanitized</param>
        /// <returns>A degree measure between 0.0 (inclusive) and 360.0 (exclusive).</returns>
        public static double SanitizeDegrees(double degrees)
        {
            var singleRotation = degrees % 360;
            if (singleRotation < 0)
                singleRotation += 360;
            return singleRotation;
        }

        /// <summary>
        /// Multiplies a 1x3 row vector with a 3x3 matrix.
        /// </summary>
        /// <param name="row">A 1x3 row vector</param>
        /// <param name="matrix">A 3x3 matrix</param>
        /// <returns></returns>
        public static double[] MatrixMultiply(double[] row, double[][] matrix)
        {
            double a = row[0] * matrix[0][0] + row[1] * matrix[0][1] + row[2] * matrix[0][2];
            double b = row[0] * matrix[1][0] + row[1] * matrix[1][1] + row[2] * matrix[1][2];
            double c = row[0] * matrix[2][0] + row[1] * matrix[2][1] + row[2] * matrix[2][2];
            return [a, b, c];
        }
    }
}
