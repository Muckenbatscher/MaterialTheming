namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_NormalContrast_Spec2026_Purple_Red : ITestThemeSecondSourceColor
{
    public string SourceColor => "#945CCD"; //Purple
    public string SecondSourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#BD84F8";
    public string OnPrimary => "#32005C";
    public string PrimaryContainer => "#925ACA";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#AD94C5";
    public string OnSecondary => "#2A163F";
    public string SecondaryContainer => "#3C2750";
    public string OnSecondaryContainer => "#C0A6D8";
    // Tertiary
    public string Tertiary => "#FF7165";
    public string OnTertiary => "#4A0003";
    public string TertiaryContainer => "#CF443B";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#FD795A";
    public string OnError => "#4A0A00";
    public string ErrorContainer => "#791902";
    public string OnErrorContainer => "#FFAF9B";
    // Surface
    public string Surface => "#120C18";
    public string SurfaceVariant => "#2D2039";
    public string OnSurface => "#F2DFFF";
    public string OnSurfaceVariant => "#B6A4C4";
    public string SurfaceDim => "#120C18";
    public string SurfaceBright => "#332740";
    public string SurfaceTint => "#BD84F8";
    // Background
    public string Background => "#120C18";
    public string OnBackground => "#F2DFFF";
    // Outline
    public string Outline => "#7F6F8C";
    public string OutlineVariant => "#50425D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF7FE";
    public string InverseOnSurface => "#5A5261";
    public string InversePrimary => "#7B43B3";
    // Primary Fixed
    public string PrimaryFixed => "#925ACA";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#844DBD";
    public string OnPrimaryFixedVariant => "#FFFBFF";
    // Secondary Fixed
    public string SecondaryFixed => "#E3C7FB";
    public string OnSecondaryFixed => "#402B54";
    public string SecondaryFixedDim => "#D4B9EC";
    public string OnSecondaryFixedVariant => "#5D4773";
    // Tertiary Fixed
    public string TertiaryFixed => "#CF443B";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#BD3730";
    public string OnTertiaryFixedVariant => "#FFFBFF";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#181020";
    public string SurfaceContainer => "#1F1628";
    public string SurfaceContainerHigh => "#261B30";
    public string SurfaceContainerHighest => "#2D2039";
}
