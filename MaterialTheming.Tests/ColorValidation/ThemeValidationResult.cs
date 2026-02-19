using MaterialTheming.Tests.ColorDifferenceCalculation;

namespace MaterialTheming.Tests.ColorValidation;

internal class ThemeValidationResult
{
    public ThemeValidationResult(Type testThemeType, IEnumerable<ColorDifference> outOfSpecColorDifferences)
    {
        TestThemeType = testThemeType;
        OutOfSpecColorDifferences = outOfSpecColorDifferences.ToList();
    }
    public Type TestThemeType { get; }
    public ICollection<ColorDifference> OutOfSpecColorDifferences { get; }
    public bool IsValid => OutOfSpecColorDifferences.Count == 0;
}
