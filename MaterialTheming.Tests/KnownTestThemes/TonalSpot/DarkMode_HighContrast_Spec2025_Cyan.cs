using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_HighContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#BBEEF8";
    public string OnPrimary => "#003138";
    public string PrimaryContainer => "#7AACB5";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#D0EAEF";
    public string OnSecondary => "#173034";
    public string SecondaryContainer => "#8FA8AD";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#D4E7FF";
    public string OnTertiary => "#082E4B";
    public string TertiaryContainer => "#BADAFF";
    public string OnTertiaryContainer => "#00233E";
    // Error
    public string Error => "#FFDEDB";
    public string OnError => "#60000A";
    public string ErrorContainer => "#FF7C76";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#0A0F10";
    public string SurfaceVariant => "#1E2729";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DDE7E9";
    public string SurfaceDim => "#0A0F10";
    public string SurfaceBright => "#242E30";
    public string SurfaceTint => "#BBEEF8";
    // Background
    public string Background => "#0A0F10";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#B0BBBD";
    public string OutlineVariant => "#9BA6A8";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F6FAFB";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#003F47";
    // Primary Fixed
    public string PrimaryFixed => "#B8EBF5";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#AADDE7";
    public string OnPrimaryFixedVariant => "#002429";
    // Secondary Fixed
    public string SecondaryFixed => "#CDE7EC";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#BFD9DE";
    public string OnSecondaryFixedVariant => "#092327";
    // Tertiary Fixed
    public string TertiaryFixed => "#BADAFF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#ADCCF1";
    public string OnTertiaryFixedVariant => "#001629";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#0E1416";
    public string SurfaceContainer => "#131B1C";
    public string SurfaceContainerHigh => "#192123";
    public string SurfaceContainerHighest => "#1E2729";
}
