namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2026_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#002449";
    public string OnPrimary => "#C7DBFF";
    public string PrimaryContainer => "#36537C";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#1A2434";
    public string OnSecondary => "#D0DAF0";
    public string SecondaryContainer => "#485364";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#281D43";
    public string OnTertiary => "#E2D3FF";
    public string TertiaryContainer => "#584C75";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#510007";
    public string OnError => "#FFCFCB";
    public string ErrorContainer => "#972B2B";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F9F9FE";
    public string SurfaceVariant => "#DFE2EC";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#20242B";
    public string SurfaceDim => "#D7DAE4";
    public string SurfaceBright => "#F9F9FE";
    public string SurfaceTint => "#002449";
    // Background
    public string Background => "#F9F9FE";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#3F434B";
    public string OutlineVariant => "#4E525A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0C0E12";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#AAC6F6";
    // Primary Fixed
    public string PrimaryFixed => "#36537C";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#2A476F";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#485364";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#3D4758";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#584C75";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#4C4068";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F2F3FA";
    public string SurfaceContainer => "#ECEDF6";
    public string SurfaceContainerHigh => "#E6E8F1";
    public string SurfaceContainerHighest => "#DFE2EC";
}
