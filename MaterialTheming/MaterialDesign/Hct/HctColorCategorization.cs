namespace MaterialTheming.MaterialDesign.Hct;

internal class HctColorCategorization
{
    private static bool IsInsideInclusiveRange(double value, double min, double max)
        => value >= min && value <= max;

    public static bool IsBlue(double hue)
        => IsInsideInclusiveRange(hue, 250, 270);

    public static bool IsYellow(double hue)
        => IsInsideInclusiveRange(hue, 105, 125);

    public static bool IsCyan(double hue)
        => IsInsideInclusiveRange(hue, 170, 207);
}
