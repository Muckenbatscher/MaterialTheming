using MaterialTheming.MaterialDesign;
using MaterialTheming.MaterialThemeBuilderConversion.SerializationModels;

namespace MaterialTheming.MaterialThemeBuilderConversion;

internal class MaterialThemeBuilderThemeColorsExtractor
{
    public static ThemeColors CreateFromMaterialDesignJson(string materialDesignJson, ThemeMode mode, ContrastLevel contrastLevel)
    {
        var materialTheme = MaterialThemeDeserializer.Deserialize(materialDesignJson)
            ?? throw new ArgumentException("Material design theme could not be parsed from the supplied JSON content.");
        Scheme? selectedScheme = null;
        if (mode == ThemeMode.Light && contrastLevel == ContrastLevel.Normal)
            selectedScheme = materialTheme.Schemes.Light;
        else if (mode == ThemeMode.Light && contrastLevel == ContrastLevel.Medium)
            selectedScheme = materialTheme.Schemes.LightMediumContrast;
        else if (mode == ThemeMode.Light && contrastLevel == ContrastLevel.High)
            selectedScheme = materialTheme.Schemes.LightHighContrast;
        else if (mode == ThemeMode.Dark && contrastLevel == ContrastLevel.Normal)
            selectedScheme = materialTheme.Schemes.Dark;
        else if (mode == ThemeMode.Dark && contrastLevel == ContrastLevel.Medium)
            selectedScheme = materialTheme.Schemes.DarkMediumContrast;
        else if (mode == ThemeMode.Dark && contrastLevel == ContrastLevel.High)
            selectedScheme = materialTheme.Schemes.DarkHighContrast;
        else
            throw new ArgumentException("Invalid combination of theme mode and contrast level.");

        if (selectedScheme == null)
            throw new ArgumentException($"The requested combination of {nameof(ThemeMode)}: {mode} and {nameof(ContrastLevel)}: {contrastLevel} was not present in the supplied JSON content.");

        return MaterialThemeBuilderConverter.ConvertFromMaterialThemeBuilder(selectedScheme);
    }
}
