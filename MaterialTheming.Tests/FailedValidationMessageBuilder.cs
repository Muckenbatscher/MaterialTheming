using MaterialTheming.Tests.ColorDifferenceCalculation;
using MaterialTheming.Tests.ColorValidation;

namespace MaterialTheming.Tests;

internal static class FailedValidationMessageBuilder
{
    extension(ThemeValidationResult themeValidationResult)
    {
        public string GetFailedValidationMessage()
        {
            if (themeValidationResult.IsValid)
                return "Theme validation passed.";

            var messageLines = new List<string>
            {
                "Theme validation failed. The following color differences are out of specification:"
            };
            foreach (var colorDifference in themeValidationResult.OutOfSpecColorDifferences)
            {
                messageLines.Add($"- {GetOutOfSpecColorDifferencesMessage(colorDifference)}");
            }
            return string.Join(Environment.NewLine, messageLines);
        }
    }

    private static string GetOutOfSpecColorDifferencesMessage(ColorDifference colorDifference)
    {
        return $"{colorDifference.ColorRoleName}: Red={colorDifference.RedDifference}, Green={colorDifference.GreenDifference}, Blue={colorDifference.BlueDifference}";
    }
}
