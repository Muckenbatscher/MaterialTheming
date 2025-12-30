namespace MaterialTheming.MaterialDesign;

internal class TargetToneProvider
{
    private static readonly Dictionary<TargetToneMapKey, double> _toneMap = new()
    {
        {new TargetToneMapKey(ThemeMode.Dark, ContrastLevel.Normal, true), 80},
        {new TargetToneMapKey(ThemeMode.Dark, ContrastLevel.Normal, false), 30},
        {new TargetToneMapKey(ThemeMode.Dark, ContrastLevel.Medium, true), 85},
        {new TargetToneMapKey(ThemeMode.Dark, ContrastLevel.Medium, false), 25},
        {new TargetToneMapKey(ThemeMode.Dark, ContrastLevel.High, true), 90},
        {new TargetToneMapKey(ThemeMode.Dark, ContrastLevel.High, false), 20},

        {new TargetToneMapKey(ThemeMode.Light, ContrastLevel.Normal, true), 45},
        {new TargetToneMapKey(ThemeMode.Light, ContrastLevel.Normal, false), 100},
        {new TargetToneMapKey(ThemeMode.Light, ContrastLevel.Medium, true), 40},
        {new TargetToneMapKey(ThemeMode.Light, ContrastLevel.Medium, false), 100},
        {new TargetToneMapKey(ThemeMode.Light, ContrastLevel.High, true), 35},
        {new TargetToneMapKey(ThemeMode.Light, ContrastLevel.High, false), 100}
    };
    public static double GetTone(ThemeMode mode, ContrastLevel contrastLevel, bool isBackground)
    {
        var searchedKey = new TargetToneMapKey(mode, contrastLevel, isBackground);
        return _toneMap[searchedKey];
    }

    private static readonly Dictionary<TargetToneMapKey, double> _containerToneMap = new()
    {
        {new TargetToneMapKey(ThemeMode.Dark, ContrastLevel.Normal, true), 35},
        {new TargetToneMapKey(ThemeMode.Dark, ContrastLevel.Normal, false), 90},
        {new TargetToneMapKey(ThemeMode.Dark, ContrastLevel.Medium, true), 30},
        {new TargetToneMapKey(ThemeMode.Dark, ContrastLevel.Medium, false), 95},
        {new TargetToneMapKey(ThemeMode.Dark, ContrastLevel.High, true), 25},
        {new TargetToneMapKey(ThemeMode.Dark, ContrastLevel.High, false), 98},

        {new TargetToneMapKey(ThemeMode.Light, ContrastLevel.Normal, true), 90},
        {new TargetToneMapKey(ThemeMode.Light, ContrastLevel.Normal, false), 35},
        {new TargetToneMapKey(ThemeMode.Light, ContrastLevel.Medium, true), 95},
        {new TargetToneMapKey(ThemeMode.Light, ContrastLevel.Medium, false), 30},
        {new TargetToneMapKey(ThemeMode.Light, ContrastLevel.High, true), 98},
        {new TargetToneMapKey(ThemeMode.Light, ContrastLevel.High, false), 25}
    };
    public static double GetContainerTone(ThemeMode mode, ContrastLevel contrastLevel, bool isBackground)
    {
        var searchedKey = new TargetToneMapKey(mode, contrastLevel, isBackground);
        return _containerToneMap[searchedKey];
    }

    private static readonly Dictionary<TargetToneMapKey, double> _surfaceToneMap = new()
    {
        {new TargetToneMapKey(ThemeMode.Dark, ContrastLevel.Normal, true), 5},
        {new TargetToneMapKey(ThemeMode.Dark, ContrastLevel.Normal, false), 90},
        {new TargetToneMapKey(ThemeMode.Dark, ContrastLevel.Medium, true), 3},
        {new TargetToneMapKey(ThemeMode.Dark, ContrastLevel.Medium, false), 95},
        {new TargetToneMapKey(ThemeMode.Dark, ContrastLevel.High, true), 2},
        {new TargetToneMapKey(ThemeMode.Dark, ContrastLevel.High, false), 98},

        {new TargetToneMapKey(ThemeMode.Light, ContrastLevel.Normal, true), 98},
        {new TargetToneMapKey(ThemeMode.Light, ContrastLevel.Normal, false), 10},
        {new TargetToneMapKey(ThemeMode.Light, ContrastLevel.Medium, true), 99},
        {new TargetToneMapKey(ThemeMode.Light, ContrastLevel.Medium, false), 5},
        {new TargetToneMapKey(ThemeMode.Light, ContrastLevel.High, true), 99},
        {new TargetToneMapKey(ThemeMode.Light, ContrastLevel.High, false), 3}
    };
    public static double GetSurfaceTone(ThemeMode mode, ContrastLevel contrastLevel, bool isBackground)
    {
        var searchedKey = new TargetToneMapKey(mode, contrastLevel, isBackground);
        return _surfaceToneMap[searchedKey];
    }

    private static readonly Dictionary<TargetToneMapKey, double> _surfaceVariantToneMap = new()
    {
        {new TargetToneMapKey(ThemeMode.Dark, ContrastLevel.Normal, true), 30},
        {new TargetToneMapKey(ThemeMode.Dark, ContrastLevel.Normal, false), 80},
        {new TargetToneMapKey(ThemeMode.Dark, ContrastLevel.Medium, true), 25},
        {new TargetToneMapKey(ThemeMode.Dark, ContrastLevel.Medium, false), 95},
        {new TargetToneMapKey(ThemeMode.Dark, ContrastLevel.High, true), 20},
        {new TargetToneMapKey(ThemeMode.Dark, ContrastLevel.High, false), 98},

        {new TargetToneMapKey(ThemeMode.Light, ContrastLevel.Normal, true), 80},
        {new TargetToneMapKey(ThemeMode.Light, ContrastLevel.Normal, false), 30},
        {new TargetToneMapKey(ThemeMode.Light, ContrastLevel.Medium, true), 95},
        {new TargetToneMapKey(ThemeMode.Light, ContrastLevel.Medium, false), 25},
        {new TargetToneMapKey(ThemeMode.Light, ContrastLevel.High, true), 98},
        {new TargetToneMapKey(ThemeMode.Light, ContrastLevel.High, false), 20}
    };
    public static double GetSurfaceVariantTone(ThemeMode mode, ContrastLevel contrastLevel, bool isBackground)
    {
        var searchedKey = new TargetToneMapKey(mode, contrastLevel, isBackground);
        return _surfaceVariantToneMap[searchedKey];
    }

    public static double GetSurfaceContainerLowestTone(ThemeMode mode) => mode == ThemeMode.Dark ? 0 : 100;
    public static double GetSurfaceContainerLowTone(ThemeMode mode) => mode == ThemeMode.Dark ? 6 : 96;
    public static double GetSurfaceContainerTone(ThemeMode mode) => mode == ThemeMode.Dark ? 12 : 92;
    public static double GetSurfaceContainerHighTone(ThemeMode mode) => mode == ThemeMode.Dark ? 18 : 89;
    public static double GetSurfaceContainerHighestTone(ThemeMode mode) => mode == ThemeMode.Dark ? 22 : 86;
}
