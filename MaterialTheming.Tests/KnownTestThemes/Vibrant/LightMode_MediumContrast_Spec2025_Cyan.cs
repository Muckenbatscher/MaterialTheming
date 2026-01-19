namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#00464F";
    public string OnPrimary => "#41E8FF";
    public string PrimaryContainer => "#00818F";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#004655";
    public string OnSecondary => "#81E1FF";
    public string SecondaryContainer => "#007F99";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#003F7B";
    public string OnTertiary => "#BED5FF";
    public string TertiaryContainer => "#2675CF";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#850012";
    public string OnError => "#FFC7C2";
    public string ErrorContainer => "#D7383B";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#EAF9FF";
    public string SurfaceVariant => "#A0E7FF";
    public string OnSurface => "#00232C";
    public string OnSurfaceVariant => "#054654";
    public string SurfaceDim => "#8EE0FA";
    public string SurfaceBright => "#EAF9FF";
    public string SurfaceTint => "#00464F";
    // Background
    public string Background => "#EAF9FF";
    public string OnBackground => "#00232C";
    // Outline
    public string Outline => "#2D6272";
    public string OutlineVariant => "#4B7E8E";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#001016";
    public string InverseOnSurface => "#99CDDE";
    public string InversePrimary => "#00E3FC";
    // Primary Fixed
    public string PrimaryFixed => "#00818F";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#007380";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#007F99";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#007289";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#2675CF";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#0968C1";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#DBF5FF";
    public string SurfaceContainer => "#C3EFFF";
    public string SurfaceContainerHigh => "#B2EBFF";
    public string SurfaceContainerHighest => "#A0E7FF";
}
