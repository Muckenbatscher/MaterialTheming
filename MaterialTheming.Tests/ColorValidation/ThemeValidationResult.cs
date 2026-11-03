using MaterialTheming.Tests.ColorDifferenceCalculation;

namespace MaterialTheming.Tests.ColorValidation;

internal class ThemeValidationResult
{
    public ThemeValidationResult(string testThemeName, IEnumerable<ColorDifference> outOfSpecColorDifferences)
    {
        TestThemeName = testThemeName;
        OutOfSpecColorDifferences = [.. outOfSpecColorDifferences];
    }

    public string TestThemeName { get; }
    public ICollection<ColorDifference> OutOfSpecColorDifferences { get; }
    public bool IsValid => OutOfSpecColorDifferences.Count == 0;
}
