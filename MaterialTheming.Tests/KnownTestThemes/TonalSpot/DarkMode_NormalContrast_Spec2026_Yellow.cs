namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2026_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#CCC98D";
    public string OnPrimary => "#434214";
    public string PrimaryContainer => "#555424";
    public string OnPrimaryContainer => "#E9E6A8";
    // Secondary
    public string Secondary => "#CBC8A4";
    public string OnSecondary => "#424127";
    public string SecondaryContainer => "#3D3D22";
    public string OnSecondaryContainer => "#C3C19D";
    // Tertiary
    public string Tertiary => "#FFE4C0";
    public string OnTertiary => "#6D501D";
    public string TertiaryContainer => "#FED494";
    public string OnTertiaryContainer => "#644715";
    // Error
    public string Error => "#F97758";
    public string OnError => "#450900";
    public string ErrorContainer => "#85230A";
    public string OnErrorContainer => "#FF9B82";
    // Surface
    public string Surface => "#0F0E08";
    public string SurfaceVariant => "#27261A";
    public string OnSurface => "#E9E6D3";
    public string OnSurfaceVariant => "#AEAC9A";
    public string SurfaceDim => "#0F0E08";
    public string SurfaceBright => "#2D2D20";
    public string SurfaceTint => "#CCC98D";
    // Background
    public string Background => "#0F0E08";
    public string OnBackground => "#E9E6D3";
    // Outline
    public string Outline => "#787666";
    public string OutlineVariant => "#4A483A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FDF9EE";
    public string InverseOnSurface => "#57554D";
    public string InversePrimary => "#626130";
    // Primary Fixed
    public string PrimaryFixed => "#E8E6A7";
    public string OnPrimaryFixed => "#424113";
    public string PrimaryFixedDim => "#DAD79A";
    public string OnPrimaryFixedVariant => "#5F5E2C";
    // Secondary Fixed
    public string SecondaryFixed => "#E7E4BF";
    public string OnSecondaryFixed => "#414126";
    public string SecondaryFixedDim => "#D9D6B1";
    public string OnSecondaryFixedVariant => "#5E5D40";
    // Tertiary Fixed
    public string TertiaryFixed => "#FED494";
    public string OnTertiaryFixed => "#4F3503";
    public string TertiaryFixedDim => "#EFC688";
    public string OnTertiaryFixedVariant => "#6E511E";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#14140C";
    public string SurfaceContainer => "#1A1A11";
    public string SurfaceContainerHigh => "#212016";
    public string SurfaceContainerHighest => "#27261A";
}
