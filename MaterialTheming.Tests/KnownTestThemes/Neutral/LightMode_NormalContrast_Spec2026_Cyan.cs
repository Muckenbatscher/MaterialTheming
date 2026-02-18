namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2026_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#576062";
    public string OnPrimary => "#F0F9FB";
    public string PrimaryContainer => "#DBE4E6";
    public string OnPrimaryContainer => "#4A5355";
    // Secondary
    public string Secondary => "#5C6060";
    public string OnSecondary => "#F7F9FA";
    public string SecondaryContainer => "#E1E3E3";
    public string OnSecondaryContainer => "#4F5253";
    // Tertiary
    public string Tertiary => "#486272";
    public string OnTertiary => "#F4FAFF";
    public string TertiaryContainer => "#D0ECFF";
    public string OnTertiaryContainer => "#3E5868";
    // Error
    public string Error => "#9F403D";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#FE8983";
    public string OnErrorContainer => "#752121";
    // Surface
    public string Surface => "#FBF9F8";
    public string SurfaceVariant => "#E2E2E3";
    public string OnSurface => "#313333";
    public string OnSurfaceVariant => "#5D5F60";
    public string SurfaceDim => "#D9DADA";
    public string SurfaceBright => "#FBF9F8";
    public string SurfaceTint => "#576062";
    // Background
    public string Background => "#FBF9F8";
    public string OnBackground => "#313333";
    // Outline
    public string Outline => "#797B7B";
    public string OutlineVariant => "#B1B2B2";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0E0E0E";
    public string InverseOnSurface => "#9E9D9C";
    public string InversePrimary => "#E6F0F2";
    // Primary Fixed
    public string PrimaryFixed => "#DBE4E6";
    public string OnPrimaryFixed => "#384143";
    public string PrimaryFixedDim => "#CDD6D8";
    public string OnPrimaryFixedVariant => "#545D5F";
    // Secondary Fixed
    public string SecondaryFixed => "#E1E3E3";
    public string OnSecondaryFixed => "#3C4041";
    public string SecondaryFixedDim => "#D2D5D5";
    public string OnSecondaryFixedVariant => "#595C5D";
    // Tertiary Fixed
    public string TertiaryFixed => "#D0ECFF";
    public string OnTertiaryFixed => "#2C4655";
    public string TertiaryFixedDim => "#C2DEF0";
    public string OnTertiaryFixedVariant => "#486272";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F5F3F3";
    public string SurfaceContainer => "#EEEEED";
    public string SurfaceContainerHigh => "#E8E8E8";
    public string SurfaceContainerHighest => "#E2E2E3";
}
