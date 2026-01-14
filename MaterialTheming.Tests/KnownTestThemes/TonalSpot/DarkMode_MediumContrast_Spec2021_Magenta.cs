using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFCFE4";
    public string OnPrimary => "#451230";
    public string PrimaryContainer => "#C17C9E";
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
    public string Surface => "#181114";
    public string SurfaceVariant => "#504348";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#EAD8DE";
    public string SurfaceDim => "#181114";
    public string SurfaceBright => "#4B4246";
    public string SurfaceTint => "#FCB0D5";
    // Background
    public string Background => "#181114";
    public string OnBackground => "#EEDFE3";
    // Outline
    public string Outline => "#BFADB3";
    public string OutlineVariant => "#9C8C92";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EEDFE3";
    public string InverseOnSurface => "#30282B";
    public string InversePrimary => "#6E3554";
    // Primary Fixed
    public string PrimaryFixed => "#FFD8E8";
    public string OnPrimaryFixed => "#2A001A";
    public string PrimaryFixedDim => "#FCB0D5";
    public string OnPrimaryFixedVariant => "#592341";
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
    public string SurfaceContainerLowest => "#0C0608";
    public string SurfaceContainerLow => "#231B1F";
    public string SurfaceContainer => "#2E2629";
    public string SurfaceContainerHigh => "#393034";
    public string SurfaceContainerHighest => "#443B3F";
}
