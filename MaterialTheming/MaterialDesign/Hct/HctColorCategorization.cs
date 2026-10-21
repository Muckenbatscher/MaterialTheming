namespace MaterialTheming.MaterialDesign.Hct;

internal class HctColorCategorization
{
    /// <summary>
    /// Determines if a value is inside a range, inclusive of the minimum and exclusive of the maximum.
    /// </summary>
    /// <param name="value">The value to validate.</param>
    /// <param name="min">The lower limit of the range (inclusive)</param>
    /// <param name="max">The upper limit of the range (exclusive)</param>
    /// <returns><c>true</c> if the value is in the range.
    /// <br/><c>false</c> if the value is outside the range.</returns>
    private static bool IsInsideRange(double value, double min, double max)
        => value >= min && value < max;

    public static bool IsBlue(double hue)
        => IsInsideRange(hue, 250, 270);

    public static bool IsYellow(double hue)
        => IsInsideRange(hue, 105, 125);

    public static bool IsCyan(double hue)
        => IsInsideRange(hue, 170, 207);
}
