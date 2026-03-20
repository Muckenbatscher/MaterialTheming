#if NETFRAMEWORK || NETSTANDARD
namespace MaterialTheming.System.Double.Extension;

internal static class DoubleExtension
{
    extension(double)
    {
        public static double Clamp(double value, double min, double max)
        {
            if (min > max)
                throw new ArgumentException("Das Minimum darf nicht größer als das Maximum sein.");

            if (double.IsNaN(value))
                return double.NaN;

            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }

        public static double Lerp(double start, double end, double amount)
        {
            return start + (end - start) * amount;
        }
    }
}
#endif