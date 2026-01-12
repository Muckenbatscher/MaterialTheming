using MaterialTheming.ColorDefinitions;

namespace MaterialTheming.Tests.ColorDifferenceCalculation;

internal class ColorDifference
{
    public ColorDifference(string colorRoleName, RgbColor actualColor, RgbColor expectedColor)
    {
        ColorRoleName = colorRoleName;
        ActualColor = actualColor;
        ExpectedColor = expectedColor;

        RedDifference = expectedColor.Red - actualColor.Red;
        GreenDifference = expectedColor.Green - actualColor.Green;
        BlueDifference = expectedColor.Blue - actualColor.Blue;
    }

    public string ColorRoleName { get; }
    public RgbColor ExpectedColor { get; }
    public RgbColor ActualColor { get; }
    public int RedDifference { get; }
    public int GreenDifference { get; }
    public int BlueDifference { get; }
}