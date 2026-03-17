using MaterialTheming.Tests.ColorDifferenceCalculation;

namespace MaterialTheming.Tests.ColorValidation;

internal class ColorDifferenceValidationService
{
    public const int MaxAllowedDifferencePerChannel = 0;
    public const int MaxAllowedTotalDifference = 0;

    public static IEnumerable<ColorDifference> FilterToOutOfSpecColorDifferences(IEnumerable<ColorDifference> colorDifferences)
    {
        return colorDifferences.Where(ColorDifferenceIsOutOfSpec);
    }

    private static bool ColorDifferenceIsOutOfSpec(ColorDifference colorDifference)
    {
        var absoluteDifferences = new[]
        {
            Math.Abs(colorDifference.RedDifference),
            Math.Abs(colorDifference.GreenDifference),
            Math.Abs(colorDifference.BlueDifference)
        };
        bool singleChannelOutOfSpec = absoluteDifferences.Any(diff => diff > MaxAllowedDifferencePerChannel);
        bool totalOutOfSpec = absoluteDifferences.Sum() > MaxAllowedTotalDifference;

        return singleChannelOutOfSpec || totalOutOfSpec;
    }
}
