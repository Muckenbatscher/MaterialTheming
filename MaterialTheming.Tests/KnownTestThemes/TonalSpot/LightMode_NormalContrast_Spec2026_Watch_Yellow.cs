namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2026_Watch_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#E9E698";
    public string OnPrimary => "#424103";
    public string PrimaryContainer => "#4A490A";
    public string OnPrimaryContainer => "#E6E496";
    // Secondary
    public string Secondary => "#E7E4BF";
    public string OnSecondary => "#414126";
    public string SecondaryContainer => "#49482D";
    public string OnSecondaryContainer => "#E5E2BD";
    // Tertiary
    public string Tertiary => "#FFD087";
    public string OnTertiary => "#4D3300";
    public string TertiaryContainer => "#E1B46E";
    public string OnTertiaryContainer => "#402A00";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#3B0600";
    public string ErrorContainer => "#7D2C19";
    public string OnErrorContainer => "#FFD7CE";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#27270D";
    public string OnSurface => "#ECE9D2";
    public string OnSurfaceVariant => "#D2CFB9";
    public string SurfaceDim => "#0F0F04";
    public string SurfaceBright => "#2E2D13";
    public string SurfaceTint => "#E9E698";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#A9A692";
    public string OutlineVariant => "#888673";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FEFAE3";
    public string InverseOnSurface => "#575644";
    public string InversePrimary => "#595719";
    // Primary Fixed
    public string PrimaryFixed => "#E9E698";
    public string OnPrimaryFixed => "#424103";
    public string PrimaryFixedDim => "#DAD88C";
    public string OnPrimaryFixedVariant => "#4A490A";
    // Secondary Fixed
    public string SecondaryFixed => "#E7E4BF";
    public string OnSecondaryFixed => "#414126";
    public string SecondaryFixedDim => "#D9D6B1";
    public string OnSecondaryFixedVariant => "#49482D";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFD087";
    public string OnTertiaryFixed => "#4D3300";
    public string TertiaryFixedDim => "#F0C27B";
    public string OnTertiaryFixedVariant => "#604103";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#272618";
    public string SurfaceContainer => "#323122";
    public string SurfaceContainerHigh => "#3D3C2C";
    public string SurfaceContainerHighest => "#27270D";
}
