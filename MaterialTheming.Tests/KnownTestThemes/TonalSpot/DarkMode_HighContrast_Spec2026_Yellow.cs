namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_HighContrast_Spec2026_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#EBE8AA";
    public string OnPrimary => "#2E2E02";
    public string PrimaryContainer => "#A8A66E";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#EAE7C2";
    public string OnSecondary => "#2E2D14";
    public string SecondaryContainer => "#A7A583";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFE4C0";
    public string OnTertiary => "#402900";
    public string TertiaryContainer => "#FED494";
    public string OnTertiaryContainer => "#332000";
    // Error
    public string Error => "#FFDED7";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#FF7E5E";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#0F0E08";
    public string SurfaceVariant => "#27261A";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E9E6D3";
    public string SurfaceDim => "#0F0E08";
    public string SurfaceBright => "#2D2D20";
    public string SurfaceTint => "#EBE8AA";
    // Background
    public string Background => "#0F0E08";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#BCB9A7";
    public string OutlineVariant => "#A7A493";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FDF9EE";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#3B3A0C";
    // Primary Fixed
    public string PrimaryFixed => "#E8E6A7";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#DAD79A";
    public string OnPrimaryFixedVariant => "#212100";
    // Secondary Fixed
    public string SecondaryFixed => "#E7E4BF";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#D9D6B1";
    public string OnSecondaryFixedVariant => "#212009";
    // Tertiary Fixed
    public string TertiaryFixed => "#FED494";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#EFC688";
    public string OnTertiaryFixedVariant => "#231500";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#14140C";
    public string SurfaceContainer => "#1A1A11";
    public string SurfaceContainerHigh => "#212016";
    public string SurfaceContainerHighest => "#27261A";
}
