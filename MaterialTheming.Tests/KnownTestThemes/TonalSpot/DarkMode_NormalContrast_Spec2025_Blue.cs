namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#B2C8ED";
    public string OnPrimary => "#2C415F";
    public string PrimaryContainer => "#3F5373";
    public string OnPrimaryContainer => "#D6E4FF";
    // Secondary
    public string Secondary => "#BDC7DC";
    public string OnSecondary => "#374151";
    public string SecondaryContainer => "#323C4C";
    public string OnSecondaryContainer => "#B5C0D4";
    // Tertiary
    public string Tertiary => "#E7DAFF";
    public string OnTertiary => "#554972";
    public string TertiaryContainer => "#DACAFB";
    public string OnTertiaryContainer => "#4D4169";
    // Error
    public string Error => "#FA746F";
    public string OnError => "#490006";
    public string ErrorContainer => "#871F21";
    public string OnErrorContainer => "#FF9993";
    // Surface
    public string Surface => "#0C0E12";
    public string SurfaceVariant => "#22262D";
    public string OnSurface => "#E2E5EF";
    public string OnSurfaceVariant => "#A8ABB4";
    public string SurfaceDim => "#0C0E12";
    public string SurfaceBright => "#282C34";
    public string SurfaceTint => "#B2C8ED";
    // Background
    public string Background => "#0C0E12";
    public string OnBackground => "#E2E5EF";
    // Outline
    public string Outline => "#72757E";
    public string OutlineVariant => "#444850";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F9F9FE";
    public string InverseOnSurface => "#535559";
    public string InversePrimary => "#4B6080";
    // Primary Fixed
    public string PrimaryFixed => "#C3D8FE";
    public string OnPrimaryFixed => "#233957";
    public string PrimaryFixedDim => "#B5CAEF";
    public string OnPrimaryFixedVariant => "#405575";
    // Secondary Fixed
    public string SecondaryFixed => "#D9E3F8";
    public string OnSecondaryFixed => "#364051";
    public string SecondaryFixedDim => "#CAD5EA";
    public string OnSecondaryFixedVariant => "#525C6E";
    // Tertiary Fixed
    public string TertiaryFixed => "#DACAFB";
    public string OnTertiaryFixed => "#392E55";
    public string TertiaryFixedDim => "#CBBCED";
    public string OnTertiaryFixedVariant => "#564A73";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#111318";
    public string SurfaceContainer => "#171A1F";
    public string SurfaceContainerHigh => "#1C2026";
    public string SurfaceContainerHighest => "#22262D";
}
