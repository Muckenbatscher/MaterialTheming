namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#005CAB";
    public string OnPrimary => "#EEF2FF";
    public string PrimaryContainer => "#5BA2FF";
    public string OnPrimaryContainer => "#002347";
    // Secondary
    public string Secondary => "#2656B7";
    public string OnSecondary => "#F1F2FF";
    public string SecondaryContainer => "#C2D1FF";
    public string OnSecondaryContainer => "#0041A0";
    // Tertiary
    public string Tertiary => "#823E9B";
    public string OnTertiary => "#FFEDFE";
    public string TertiaryContainer => "#E094F8";
    public string OnTertiaryContainer => "#52076C";
    // Error
    public string Error => "#B31B25";
    public string OnError => "#FFEFEE";
    public string ErrorContainer => "#FB5151";
    public string OnErrorContainer => "#570008";
    // Surface
    public string Surface => "#F6F6FF";
    public string SurfaceVariant => "#D2DCFF";
    public string OnSurface => "#1F2D51";
    public string OnSurfaceVariant => "#4C5B81";
    public string SurfaceDim => "#C6D3FF";
    public string SurfaceBright => "#F6F6FF";
    public string SurfaceTint => "#005CAB";
    // Background
    public string Background => "#F6F6FF";
    public string OnBackground => "#1F2D51";
    // Outline
    public string Outline => "#68769E";
    public string OutlineVariant => "#9EACD7";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#000C2B";
    public string InverseOnSurface => "#8E9CC6";
    public string InversePrimary => "#2B91FF";
    // Primary Fixed
    public string PrimaryFixed => "#5BA2FF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#3594FF";
    public string OnPrimaryFixedVariant => "#002C58";
    // Secondary Fixed
    public string SecondaryFixed => "#C2D1FF";
    public string OnSecondaryFixed => "#002F79";
    public string SecondaryFixedDim => "#ADC3FF";
    public string OnSecondaryFixedVariant => "#144BAB";
    // Tertiary Fixed
    public string TertiaryFixed => "#E094F8";
    public string OnTertiaryFixed => "#2D003E";
    public string TertiaryFixedDim => "#D187E9";
    public string OnTertiaryFixedVariant => "#5C1675";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EEF0FF";
    public string SurfaceContainer => "#E2E7FF";
    public string SurfaceContainerHigh => "#DAE2FF";
    public string SurfaceContainerHighest => "#D2DCFF";
}
