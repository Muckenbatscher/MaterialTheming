namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FED874";
    public string OnPrimary => "#302400";
    public string PrimaryContainer => "#AD8D31";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#E4D6FF";
    public string OnSecondary => "#2A203F";
    public string SecondaryContainer => "#978BB0";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#A9E5FF";
    public string OnTertiary => "#002A36";
    public string TertiaryContainer => "#5D99B0";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#0D1418";
    public string SurfaceVariant => "#3B494F";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#D0DFE6";
    public string SurfaceDim => "#0D1418";
    public string SurfaceBright => "#3E464A";
    public string SurfaceTint => "#E7C361";
    // Background
    public string Background => "#0D1418";
    public string OnBackground => "#DCE4E8";
    // Outline
    public string Outline => "#A5B4BC";
    public string OutlineVariant => "#84939A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#DCE4E8";
    public string InverseOnSurface => "#232B2F";
    public string InversePrimary => "#5A4500";
    // Primary Fixed
    public string PrimaryFixed => "#FFDF90";
    public string OnPrimaryFixed => "#181000";
    public string PrimaryFixedDim => "#E7C361";
    public string OnPrimaryFixedVariant => "#443400";
    // Secondary Fixed
    public string SecondaryFixed => "#EADDFF";
    public string OnSecondaryFixed => "#150B2A";
    public string SecondaryFixedDim => "#CEC0E8";
    public string OnSecondaryFixedVariant => "#3B3151";
    // Tertiary Fixed
    public string TertiaryFixed => "#BAEAFF";
    public string OnTertiaryFixed => "#00141B";
    public string TertiaryFixedDim => "#93CFE8";
    public string OnTertiaryFixedVariant => "#003B4C";
    // Surface Container
    public string SurfaceContainerLowest => "#03080B";
    public string SurfaceContainerLow => "#171F22";
    public string SurfaceContainer => "#21292D";
    public string SurfaceContainerHigh => "#2C3437";
    public string SurfaceContainerHighest => "#373F43";
}
