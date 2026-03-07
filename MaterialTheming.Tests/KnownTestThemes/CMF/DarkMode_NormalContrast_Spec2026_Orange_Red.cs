namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_NormalContrast_Spec2026_Orange_Red : ITestThemeSecondSourceColor
{
    public string SourceColor => "#D77837"; //Orange
    public string SecondSourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#EA8745";
    public string OnPrimary => "#3D1800";
    public string PrimaryContainer => "#DA7A39";
    public string OnPrimaryContainer => "#250C00";
    // Secondary
    public string Secondary => "#C89273";
    public string OnSecondary => "#371703";
    public string SecondaryContainer => "#4B270F";
    public string OnSecondaryContainer => "#DCA484";
    // Tertiary
    public string Tertiary => "#FF7165";
    public string OnTertiary => "#4A0003";
    public string TertiaryContainer => "#CF443B";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#FE8987";
    public string OnError => "#5B0C13";
    public string ErrorContainer => "#4C010A";
    public string OnErrorContainer => "#F07E7C";
    // Surface
    public string Surface => "#170B05";
    public string SurfaceVariant => "#382011";
    public string OnSurface => "#FFDFCE";
    public string OnSurfaceVariant => "#CAA38D";
    public string SurfaceDim => "#170B05";
    public string SurfaceBright => "#3F2617";
    public string SurfaceTint => "#EA8745";
    // Background
    public string Background => "#170B05";
    public string OnBackground => "#FFDFCE";
    // Outline
    public string Outline => "#906E5B";
    public string OutlineVariant => "#5E4230";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F5";
    public string InverseOnSurface => "#645147";
    public string InversePrimary => "#994805";
    // Primary Fixed
    public string PrimaryFixed => "#DA7A39";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#CA6E2E";
    public string OnPrimaryFixedVariant => "#371500";
    // Secondary Fixed
    public string SecondaryFixed => "#FABF9D";
    public string OnSecondaryFixed => "#4B270F";
    public string SecondaryFixedDim => "#EBB290";
    public string OnSecondaryFixedVariant => "#6C4329";
    // Tertiary Fixed
    public string TertiaryFixed => "#CF443B";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#BD3730";
    public string OnTertiaryFixedVariant => "#FFFBFF";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1F1006";
    public string SurfaceContainer => "#27150A";
    public string SurfaceContainerHigh => "#2F1B0E";
    public string SurfaceContainerHighest => "#382011";
}
