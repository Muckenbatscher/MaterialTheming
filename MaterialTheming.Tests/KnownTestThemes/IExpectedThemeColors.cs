namespace MaterialTheming.Tests.KnownTestThemes;

internal interface IExpectedThemeColors
{
    public string Primary { get; }
    public string OnPrimary { get; }
    public string PrimaryContainer { get; }
    public string OnPrimaryContainer { get; }

    public string Secondary { get; }
    public string OnSecondary { get; }
    public string SecondaryContainer { get; }
    public string OnSecondaryContainer { get; }

    public string Tertiary { get; }
    public string OnTertiary { get; }
    public string TertiaryContainer { get; }
    public string OnTertiaryContainer { get; }

    public string Error { get; }
    public string OnError { get; }
    public string ErrorContainer { get; }
    public string OnErrorContainer { get; }

    public string Surface { get; }
    public string OnSurface { get; }
    public string OnSurfaceVariant { get; }

    public string SurfaceContainerLowest { get; }
    public string SurfaceContainerLow { get; }
    public string SurfaceContainer { get; }
    public string SurfaceContainerHigh { get; }
    public string SurfaceContainerHighest { get; }
}
