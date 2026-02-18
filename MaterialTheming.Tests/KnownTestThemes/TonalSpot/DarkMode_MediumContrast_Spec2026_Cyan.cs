namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2026_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#9DCFD8";
    public string OnPrimary => "#003C44";
    public string PrimaryContainer => "#4B7C85";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#B1CBD0";
    public string OnSecondary => "#223A3E";
    public string SecondaryContainer => "#60797D";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#D4E7FF";
    public string OnTertiary => "#2C4C6A";
    public string TertiaryContainer => "#BADAFF";
    public string OnTertiaryContainer => "#234361";
    // Error
    public string Error => "#FF9F99";
    public string OnError => "#60000A";
    public string ErrorContainer => "#C54D4A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#0A0F10";
    public string SurfaceVariant => "#1E2729";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#B0BBBD";
    public string SurfaceDim => "#0A0F10";
    public string SurfaceBright => "#242E30";
    public string SurfaceTint => "#9DCFD8";
    // Background
    public string Background => "#0A0F10";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#8B9597";
    public string OutlineVariant => "#6D7779";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F6FAFB";
    public string InverseOnSurface => "#34393A";
    public string InversePrimary => "#295C64";
    // Primary Fixed
    public string PrimaryFixed => "#B8EBF5";
    public string OnPrimaryFixed => "#002429";
    public string PrimaryFixedDim => "#AADDE7";
    public string OnPrimaryFixedVariant => "#0C464E";
    // Secondary Fixed
    public string SecondaryFixed => "#CDE7EC";
    public string OnSecondaryFixed => "#092327";
    public string SecondaryFixedDim => "#BFD9DE";
    public string OnSecondaryFixedVariant => "#2B4347";
    // Tertiary Fixed
    public string TertiaryFixed => "#BADAFF";
    public string OnTertiaryFixed => "#001629";
    public string TertiaryFixedDim => "#ADCCF1";
    public string OnTertiaryFixedVariant => "#183A58";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#0E1416";
    public string SurfaceContainer => "#131B1C";
    public string SurfaceContainerHigh => "#192123";
    public string SurfaceContainerHighest => "#1E2729";
}
