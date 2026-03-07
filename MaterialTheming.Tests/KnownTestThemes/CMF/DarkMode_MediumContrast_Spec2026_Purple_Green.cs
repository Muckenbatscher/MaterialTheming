namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_MediumContrast_Spec2026_Purple_Green : ITestThemeSecondSourceColor
{
    public string SourceColor => "#945CCD"; //Purple
    public string SecondSourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#D3A6FF";
    public string OnPrimary => "#430077";
    public string PrimaryContainer => "#925ACA";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#C9AEE1";
    public string OnSecondary => "#37234C";
    public string SecondaryContainer => "#836B99";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#77CB81";
    public string OnTertiary => "#003411";
    public string TertiaryContainer => "#308443";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#FF9EA2";
    public string OnError => "#600015";
    public string ErrorContainer => "#C54B56";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#120C18";
    public string SurfaceVariant => "#2D2039";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#C4B2D2";
    public string SurfaceDim => "#120C18";
    public string SurfaceBright => "#332740";
    public string SurfaceTint => "#D3A6FF";
    // Background
    public string Background => "#120C18";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#9E8DAB";
    public string OutlineVariant => "#7F6F8C";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF7FE";
    public string InverseOnSurface => "#3D3543";
    public string InversePrimary => "#7038A8";
    // Primary Fixed
    public string PrimaryFixed => "#925ACA";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#925BCB";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#E3C7FB";
    public string OnSecondaryFixed => "#16032B";
    public string SecondaryFixedDim => "#D4B9EC";
    public string OnSecondaryFixedVariant => "#402B54";
    // Tertiary Fixed
    public string TertiaryFixed => "#308443";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#318543";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#181020";
    public string SurfaceContainer => "#1F1628";
    public string SurfaceContainerHigh => "#261B30";
    public string SurfaceContainerHighest => "#2D2039";
}
