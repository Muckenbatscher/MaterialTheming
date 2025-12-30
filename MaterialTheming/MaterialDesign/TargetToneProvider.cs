namespace MaterialTheming.MaterialDesign;

internal class TargetToneProvider
{
    public static double GetTone(ThemeMode mode, ContrastLevel contrastLevel, bool isBackground)
    {
        var tones = new Dictionary<Tuple<ThemeMode, ContrastLevel, bool>, double>()
            {
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Normal, true), 80},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Normal, false), 30},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Medium, true), 85},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Medium, false), 25},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.High, true), 90},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.High, false), 20},

                {Tuple.Create(ThemeMode.Light, ContrastLevel.Normal, true), 45},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Normal, false), 100},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Medium, true), 40},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Medium, false), 100},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.High, true), 35},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.High, false), 100}
            };
        return tones[Tuple.Create(mode, contrastLevel, isBackground)];
    }

    public static double GetContainerTone(ThemeMode mode, ContrastLevel contrastLevel, bool isBackground)
    {
        var tones = new Dictionary<Tuple<ThemeMode, ContrastLevel, bool>, double>()
            {
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Normal, true), 35},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Normal, false), 90},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Medium, true), 30},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Medium, false), 95},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.High, true), 25},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.High, false), 98},

                {Tuple.Create(ThemeMode.Light, ContrastLevel.Normal, true), 90},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Normal, false), 35},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Medium, true), 95},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Medium, false), 30},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.High, true), 98},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.High, false), 25}
            };

        return tones[Tuple.Create(mode, contrastLevel, isBackground)];
    }

    public static double GetSurfaceTone(ThemeMode mode, ContrastLevel contrastLevel, bool isBackground)
    {
        var tones = new Dictionary<Tuple<ThemeMode, ContrastLevel, bool>, double>()
            {
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Normal, true), 5},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Normal, false), 90},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Medium, true), 3},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Medium, false), 95},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.High, true), 2},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.High, false), 98},

                {Tuple.Create(ThemeMode.Light, ContrastLevel.Normal, true), 98},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Normal, false), 10},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Medium, true), 99},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Medium, false), 5},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.High, true), 99},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.High, false), 3}
            };

        return tones[Tuple.Create(mode, contrastLevel, isBackground)];
    }

    public static double GetSurfaceVariantTone(ThemeMode mode, ContrastLevel contrastLevel, bool isBackground)
    {
        var tones = new Dictionary<Tuple<ThemeMode, ContrastLevel, bool>, double>()
            {
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Normal, true), 30},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Normal, false), 80},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Medium, true), 25},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.Medium, false), 95},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.High, true), 20},
                {Tuple.Create(ThemeMode.Dark, ContrastLevel.High, false), 98},

                {Tuple.Create(ThemeMode.Light, ContrastLevel.Normal, true), 80},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Normal, false), 30},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Medium, true), 95},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.Medium, false), 25},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.High, true), 98},
                {Tuple.Create(ThemeMode.Light, ContrastLevel.High, false), 20}
            };

        return tones[Tuple.Create(mode, contrastLevel, isBackground)];
    }

    public static double GetSurfaceContainerLowestTone(ThemeMode mode) => mode == ThemeMode.Dark ? 0 : 100;
    public static double GetSurfaceContainerLowTone(ThemeMode mode) => mode == ThemeMode.Dark ? 6 : 96;
    public static double GetSurfaceContainerTone(ThemeMode mode) => mode == ThemeMode.Dark ? 12 : 92;
    public static double GetSurfaceContainerHighTone(ThemeMode mode) => mode == ThemeMode.Dark ? 18 : 89;
    public static double GetSurfaceContainerHighestTone(ThemeMode mode) => mode == ThemeMode.Dark ? 22 : 86;
}
