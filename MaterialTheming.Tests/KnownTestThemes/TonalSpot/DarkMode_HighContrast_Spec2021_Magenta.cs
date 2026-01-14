using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_HighContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFEBF2";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#F8ACD1";
    public string OnPrimaryContainer => "#1F0013";
    // Secondary
    public string Secondary => "#FFEBF2";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#DBBAC8";
    public string OnSecondaryContainer => "#17060F";
    // Tertiary
    public string Tertiary => "#FFECE3";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#EEB797";
    public string OnTertiaryContainer => "#190600";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#181114";
    public string SurfaceVariant => "#504348";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#181114";
    public string SurfaceBright => "#574D51";
    public string SurfaceTint => "#FCB0D5";
    // Background
    public string Background => "#181114";
    public string OnBackground => "#EEDFE3";
    // Outline
    public string Outline => "#FEEBF1";
    public string OutlineVariant => "#D0BEC4";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EEDFE3";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#6E3554";
    // Primary Fixed
    public string PrimaryFixed => "#FFD8E8";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FCB0D5";
    public string OnPrimaryFixedVariant => "#2A001A";
    // Secondary Fixed
    public string SecondaryFixed => "#FDD9E8";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#E0BDCC";
    public string OnSecondaryFixedVariant => "#1E0B15";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDBC8";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#F3BB9A";
    public string OnTertiaryFixedVariant => "#220A00";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#251D21";
    public string SurfaceContainer => "#372E32";
    public string SurfaceContainerHigh => "#42393D";
    public string SurfaceContainerHighest => "#4E4448";
}
