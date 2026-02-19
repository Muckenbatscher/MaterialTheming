namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2026_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#9DCFD8";
    public string OnPrimary => "#0E474F";
    public string PrimaryContainer => "#265962";
    public string OnPrimaryContainer => "#B9ECF6";
    // Secondary
    public string Secondary => "#B1CBD0";
    public string OnSecondary => "#2C4448";
    public string SecondaryContainer => "#273F43";
    public string OnSecondaryContainer => "#AAC4C9";
    // Tertiary
    public string Tertiary => "#D4E7FF";
    public string OnTertiary => "#375675";
    public string TertiaryContainer => "#BADAFF";
    public string OnTertiaryContainer => "#2E4D6C";
    // Error
    public string Error => "#FA746F";
    public string OnError => "#490006";
    public string ErrorContainer => "#871F21";
    public string OnErrorContainer => "#FF9993";
    // Surface
    public string Surface => "#0A0F10";
    public string SurfaceVariant => "#1E2729";
    public string OnSurface => "#DDE7E9";
    public string OnSurfaceVariant => "#A2ADAF";
    public string SurfaceDim => "#0A0F10";
    public string SurfaceBright => "#242E30";
    public string SurfaceTint => "#9DCFD8";
    // Background
    public string Background => "#0A0F10";
    public string OnBackground => "#DDE7E9";
    // Outline
    public string Outline => "#6D7779";
    public string OutlineVariant => "#404A4C";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F6FAFB";
    public string InverseOnSurface => "#515657";
    public string InversePrimary => "#34666F";
    // Primary Fixed
    public string PrimaryFixed => "#B8EBF5";
    public string OnPrimaryFixed => "#0C464E";
    public string PrimaryFixedDim => "#AADDE7";
    public string OnPrimaryFixedVariant => "#30636B";
    // Secondary Fixed
    public string SecondaryFixed => "#CDE7EC";
    public string OnSecondaryFixed => "#2B4347";
    public string SecondaryFixedDim => "#BFD9DE";
    public string OnSecondaryFixedVariant => "#475F64";
    // Tertiary Fixed
    public string TertiaryFixed => "#BADAFF";
    public string OnTertiaryFixed => "#183A58";
    public string TertiaryFixedDim => "#ADCCF1";
    public string OnTertiaryFixedVariant => "#375776";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#0E1416";
    public string SurfaceContainer => "#131B1C";
    public string SurfaceContainerHigh => "#192123";
    public string SurfaceContainerHighest => "#1E2729";
}
