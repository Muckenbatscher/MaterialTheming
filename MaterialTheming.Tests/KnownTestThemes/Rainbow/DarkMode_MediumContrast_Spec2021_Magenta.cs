namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class DarkMode_MediumContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFCFE4";
    public string OnPrimary => "#4D0334";
    public string PrimaryContainer => "#CF72A4";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#F6D3E1";
    public string OnSecondary => "#351F2A";
    public string SecondaryContainer => "#A78896";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFD3BB";
    public string OnTertiary => "#3D1D07";
    public string TertiaryContainer => "#B88668";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#131313";
    public string SurfaceVariant => "#474747";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DCDCDC";
    public string SurfaceDim => "#131313";
    public string SurfaceBright => "#444444";
    public string SurfaceTint => "#FFAFD6";
    // Background
    public string Background => "#131313";
    public string OnBackground => "#E2E2E2";
    // Outline
    public string Outline => "#B2B2B2";
    public string OutlineVariant => "#909090";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E2E2E2";
    public string InverseOnSurface => "#2A2A2A";
    public string InversePrimary => "#792B58";
    // Primary Fixed
    public string PrimaryFixed => "#FFD8E8";
    public string OnPrimaryFixed => "#2A001A";
    public string PrimaryFixedDim => "#FFAFD6";
    public string OnPrimaryFixedVariant => "#621846";
    // Secondary Fixed
    public string SecondaryFixed => "#FDD9E8";
    public string OnSecondaryFixed => "#1E0B15";
    public string SecondaryFixedDim => "#E0BDCC";
    public string OnSecondaryFixedVariant => "#472F3A";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDBC8";
    public string OnTertiaryFixed => "#220A00";
    public string TertiaryFixedDim => "#F3BB9A";
    public string OnTertiaryFixedVariant => "#512D16";
    // Surface Container
    public string SurfaceContainerLowest => "#070707";
    public string SurfaceContainerLow => "#1D1D1D";
    public string SurfaceContainer => "#282828";
    public string SurfaceContainerHigh => "#323232";
    public string SurfaceContainerHighest => "#3E3E3E";
}
