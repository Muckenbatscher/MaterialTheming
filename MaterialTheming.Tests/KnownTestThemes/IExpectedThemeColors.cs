namespace MaterialTheming.Tests.KnownTestThemes;

internal interface IExpectedThemeColors
{
    //Primary
    public string Primary { get; }
    public string OnPrimary { get; }
    public string PrimaryContainer { get; }
    public string OnPrimaryContainer { get; }

    //Secondary
    public string Secondary { get; }
    public string OnSecondary { get; }
    public string SecondaryContainer { get; }
    public string OnSecondaryContainer { get; }

    //Tertiary
    public string Tertiary { get; }
    public string OnTertiary { get; }
    public string TertiaryContainer { get; }
    public string OnTertiaryContainer { get; }

    //Error
    public string Error { get; }
    public string OnError { get; }
    public string ErrorContainer { get; }
    public string OnErrorContainer { get; }

    //Surface
    public string Surface { get; }
    public string SurfaceVariant { get; }
    public string OnSurface { get; }
    public string OnSurfaceVariant { get; }
    public string SurfaceDim { get; }
    public string SurfaceBright { get; }
    public string SurfaceTint { get; }

    //Background
    public string Background { get; }
    public string OnBackground { get; }

    //Background
    public string Outline { get; }
    public string OutlineVariant { get; }

    //Shadow
    public string Shadow { get; }
    public string Scrim { get; }

    //Inverse
    public string InverseSurface { get; }
    public string InverseOnSurface { get; }
    public string InversePrimary { get; }

    //Primary Fixed
    public string PrimaryFixed { get; }
    public string OnPrimaryFixed { get; }
    public string PrimaryFixedDim { get; }
    public string OnPrimaryFixedVariant { get; }

    //Secondary Fixed
    public string SecondaryFixed { get; }
    public string OnSecondaryFixed { get; }
    public string SecondaryFixedDim { get; }
    public string OnSecondaryFixedVariant { get; }

    //Tertiary Fixed
    public string TertiaryFixed { get; }
    public string OnTertiaryFixed { get; }
    public string TertiaryFixedDim { get; }
    public string OnTertiaryFixedVariant { get; }

    //Surface Container
    public string SurfaceContainerLowest { get; }
    public string SurfaceContainerLow { get; }
    public string SurfaceContainer { get; }
    public string SurfaceContainerHigh { get; }
    public string SurfaceContainerHighest { get; }
}
