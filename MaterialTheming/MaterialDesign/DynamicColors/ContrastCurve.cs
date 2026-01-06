using MaterialTheming.MaterialDesign.HctConversion;

namespace MaterialTheming.MaterialDesign.DynamicColors;

internal class ContrastCurve
{
    /// <summary>Value for contrast level -1.0</summary>
    private readonly double _low;

    /// <summary>Value for contrast level 0.0</summary>
    private readonly double _normal;

    /// <summary>Value for contrast level 0.5</summary>
    private readonly double _medium;

    /// <summary>Value for contrast level 1.0</summary>
    private readonly double _high;

    /// <summary>
    /// Creates a <see cref="ContrastCurve"/> object.
    /// </summary>
    /// <param name="low">Value for contrast level -1.0</param>
    /// <param name="normal">Value for contrast level 0.0</param>
    /// <param name="medium">Value for contrast level 0.5</param>
    /// <param name="high">Value for contrast level 1.0</param>
    public ContrastCurve(double low, double normal, double medium, double high)
    {
        _low = low;
        _normal = normal;
        _medium = medium;
        _high = high;
    }

    /// <summary>
    /// Returns the value at a given contrast level.
    /// </summary>
    /// <param name="contrastLevel">The contrast level. 0.0 is the default (normal); -1.0 is the lowest; 1.0 is the highest.</param>
    /// <returns>The value. For contrast ratios, a number between 1.0 and 21.0.</returns>
    public double Get(double contrastLevel)
    {
        if (contrastLevel <= -1.0)
            return _low;

        else if (contrastLevel < 0.0)
            return MathUtils.Lerp(_low, _normal, (contrastLevel - -1) / 1);

        else if (contrastLevel < 0.5)
            return MathUtils.Lerp(_normal, _medium, (contrastLevel - 0) / 0.5);

        else if (contrastLevel < 1.0)
            return MathUtils.Lerp(_medium, _high, (contrastLevel - 0.5) / 0.5);

        else
            return _high;
    }
}
