using MaterialTheming.Tests.ColorValidation;

namespace MaterialTheming.Tests;

internal class TestThemeResultCollection
{
    private ICollection<ThemeValidationResult> _themeValidationResults;

    public TestThemeResultCollection()
    {
        _themeValidationResults = new List<ThemeValidationResult>();
    }

    public void AddResult(ThemeValidationResult result) => _themeValidationResults.Add(result);

    public IEnumerable<ThemeValidationResult> InvalidResults => _themeValidationResults.Where(r => !r.IsValid);
    public bool HasInvalidResults => InvalidResults.Any();

    public string GetConcatenatedFailedResultMessage()
    {
        var invalidResultMessages = InvalidResults.Select(r => r.GetFailedValidationMessage());
        return string.Join(Environment.NewLine, invalidResultMessages);
    }
}
