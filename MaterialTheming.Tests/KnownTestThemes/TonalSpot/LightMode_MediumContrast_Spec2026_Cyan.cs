namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2026_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#004A53";
    public string OnPrimary => "#A1E5F1";
    public string PrimaryContainer => "#387E89";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#2F474B";
    public string OnSecondary => "#C4DEE4";
    public string SecondaryContainer => "#60797D";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#254563";
    public string OnTertiary => "#BFDCFF";
    public string TertiaryContainer => "#587798";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#811B1D";
    public string OnError => "#FFCECA";
    public string ErrorContainer => "#C54D4A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F6FAFB";
    public string SurfaceVariant => "#DAE4E7";
    public string OnSurface => "#1C2627";
    public string OnSurfaceVariant => "#3B4546";
    public string SurfaceDim => "#D1DCDE";
    public string SurfaceBright => "#F6FAFB";
    public string SurfaceTint => "#004A53";
    // Background
    public string Background => "#F6FAFB";
    public string OnBackground => "#1C2627";
    // Outline
    public string Outline => "#576163";
    public string OutlineVariant => "#727C7F";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0A0F10";
    public string InverseOnSurface => "#C1C5C6";
    public string InversePrimary => "#A9EEFA";
    // Primary Fixed
    public string PrimaryFixed => "#387E89";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#29717D";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#60797D";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#546C71";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#587798";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#4C6B8B";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EEF5F6";
    public string SurfaceContainer => "#E8EFF1";
    public string SurfaceContainerHigh => "#E1EAEB";
    public string SurfaceContainerHighest => "#DAE4E7";
}
