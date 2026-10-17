namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2025_Watch_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#212100";
    public string PrimaryContainer => "#8A8945";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFEFF";
    public string OnSecondary => "#212009";
    public string SecondaryContainer => "#898767";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#1F1200";
    public string TertiaryContainer => "#E1B46E";
    public string OnTertiaryContainer => "#402A00";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#390600";
    public string ErrorContainer => "#CD6951";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#27270D";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#D2CFB9";
    public string SurfaceDim => "#0F0F04";
    public string SurfaceBright => "#2E2D13";
    public string SurfaceTint => "#FFFEFF";
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
    public string InverseOnSurface => "#3A3929";
    public string InversePrimary => "#3B3A00";
    // Primary Fixed
    public string PrimaryFixed => "#E9E698";
    public string OnPrimaryFixed => "#212100";
    public string PrimaryFixedDim => "#DAD88C";
    public string OnPrimaryFixedVariant => "#424103";
    // Secondary Fixed
    public string SecondaryFixed => "#E7E4BF";
    public string OnSecondaryFixed => "#212009";
    public string SecondaryFixedDim => "#D9D6B1";
    public string OnSecondaryFixedVariant => "#414126";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFD087";
    public string OnTertiaryFixed => "#1F1200";
    public string TertiaryFixedDim => "#F0C27B";
    public string OnTertiaryFixedVariant => "#4D3300";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#272618";
    public string SurfaceContainer => "#323122";
    public string SurfaceContainerHigh => "#3D3C2C";
    public string SurfaceContainerHighest => "#27270D";
}
