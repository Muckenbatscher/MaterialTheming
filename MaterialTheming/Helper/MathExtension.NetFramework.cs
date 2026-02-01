#if NETFRAMEWORK || NETSTANDARD
using SystemMath = System.Math;
namespace MaterialTheming.System.Math.Extension;

internal class MathExtension
{
    public static double Cbrt(double value)
    {
        if (value == 0)
            return 0;

        if (value < 0)
            return -SystemMath.Pow(-value, 1.0 / 3.0);

        return SystemMath.Pow(value, 1.0 / 3.0);
    }
}
#endif