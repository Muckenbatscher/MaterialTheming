namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class LightMode_MediumContrast_Spec2026_Purple_Cyan : ITestThemeSecondSourceColor
{
    public string SourceColor => "#945CCD"; //Purple
    public string SecondSourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#5C2294";
    public string OnPrimary => "#EAD0FF";
    public string PrimaryContainer => "#925ACA";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#4F3A64";
    public string OnSecondary => "#EAD0FF";
    public string SecondaryContainer => "#836B99";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#004A53";
    public string OnTertiary => "#6DEBFF";
    public string TertiaryContainer => "#00818F";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#821929";
    public string OnError => "#FFCECE";
    public string ErrorContainer => "#C54B56";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF7FE";
    public string SurfaceVariant => "#EFDBFD";
    public string OnSurface => "#2B1F37";
    public string OnSurfaceVariant => "#4B3D58";
    public string SurfaceDim => "#E6D3F4";
    public string SurfaceBright => "#FFF7FE";
    public string SurfaceTint => "#5C2294";
    // Background
    public string Background => "#FFF7FE";
    public string OnBackground => "#2B1F37";
    // Outline
    public string Outline => "#685975";
    public string OutlineVariant => "#857592";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#140920";
    public string InverseOnSurface => "#CCC1D2";
    public string InversePrimary => "#C389FE";
    // Primary Fixed
    public string PrimaryFixed => "#925ACA";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#844DBD";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#836B99";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#765F8C";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#00818F";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#007380";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FBF0FF";
    public string SurfaceContainer => "#F7E9FF";
    public string SurfaceContainerHigh => "#F4E2FF";
    public string SurfaceContainerHighest => "#EFDBFD";
}
