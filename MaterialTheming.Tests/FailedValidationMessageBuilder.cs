using MaterialTheming.ColorDefinitions;
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

            int maxColorRoleNameLength = themeValidationResult.OutOfSpecColorDifferences.Max(x => x.ColorRoleName.Length);
            var differenceInfos = themeValidationResult.OutOfSpecColorDifferences
                .Select(difference => GetDashEnumeratedColorDifferenceInfo(difference, maxColorRoleNameLength));

            var messageLines = differenceInfos
                .Prepend("Theme validation failed. The following color differences are out of specification:");
            return string.Join(Environment.NewLine, messageLines);
        }
    }
    private static string GetDashEnumeratedColorDifferenceInfo(ColorDifference difference, int maxColorRoleNameLength)
    {
        var enumerationMark = "- ";
        var message = GetOutOfSpecColorDifferencesMessage(difference, maxColorRoleNameLength);
        var messageLines = message.Split(Environment.NewLine);
        var indentedMessageLines = new List<string>();
        for (int messageIndex = 0; messageIndex < messageLines.Length; messageIndex++)
        {
            var isFirstLine = messageIndex == 0;
            var prepend = isFirstLine
                ? enumerationMark
                : new string(' ', enumerationMark.Length);
            indentedMessageLines.Add($"{prepend}{messageLines[messageIndex]}");
        }
        return string.Join(Environment.NewLine, indentedMessageLines);
    }

    private static string GetOutOfSpecColorDifferencesMessage(ColorDifference colorDifference, int maxColorRoleNameLength)
    {
        var roleNamePrompt = ": ";
        var paddedRoleName = $"{colorDifference.ColorRoleName}{roleNamePrompt}".PadRight(maxColorRoleNameLength + roleNamePrompt.Length);
        var indentString = new string(' ', paddedRoleName.Length);
        var actualColorInfo = CreateColorInfoString(colorDifference.ActualColor);
        var expectedColorInfo = CreateColorInfoString(colorDifference.ExpectedColor);
        return $"{paddedRoleName}Actual=  {actualColorInfo} " + Environment.NewLine +
               $"{indentString}Expected={expectedColorInfo} " + Environment.NewLine +
               $"{indentString}DiffRed={colorDifference.RedDifference}, DiffGreen={colorDifference.GreenDifference}, DiffBlue={colorDifference.BlueDifference}";
    }

    private static string CreateColorInfoString(RgbColor color)
    {
        var colorHct = HctColor.FromRgbColor(color);
        var monospacedHct = CreateMonospaceHctColorString(colorHct);
        return $"{color.ToHtml()} {monospacedHct}";
    }
    private static string CreateMonospaceHctColorString(HctColor color)
    {
        string paddedHue = ((int)Math.Round(color.Hue)).ToString().PadLeft(3);
        string paddedChroma = ((int)Math.Round(color.Chroma)).ToString().PadLeft(2);
        string paddedTone = ((int)Math.Round(color.Tone)).ToString().PadLeft(3);
        return $"HCT({paddedHue}, {paddedChroma}, {paddedTone})";
    }
}
