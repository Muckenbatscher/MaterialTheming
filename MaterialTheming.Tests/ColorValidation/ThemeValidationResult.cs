using MaterialTheming.Tests.ColorDifferenceCalculation;

namespace MaterialTheming.Tests.ColorValidation;

internal class ThemeValidationResult
{
    public ThemeValidationResult(IEnumerable<ColorDifference> outOfSpecColorDifferences)
    {
        OutOfSpecColorDifferences = outOfSpecColorDifferences.ToList();
    }

    public ICollection<ColorDifference> OutOfSpecColorDifferences;
    public bool IsValid => OutOfSpecColorDifferences.Count == 0;
}
