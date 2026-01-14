using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_HighContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#F5EDFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#CDB7FF";
    public string OnPrimaryContainer => "#100032";
    // Secondary
    public string Secondary => "#F5EDFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#CCB8FA";
    public string OnSecondaryContainer => "#100032";
    // Tertiary
    public string Tertiary => "#FFEBF2";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#F8ACD1";
    public string OnTertiaryContainer => "#1F0013";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#1C1016";
    public string SurfaceVariant => "#58404B";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#1C1016";
    public string SurfaceBright => "#5C4C52";
    public string SurfaceTint => "#D0BCFF";
    // Background
    public string Background => "#1C1016";
    public string OnBackground => "#F4DDE5";
    // Outline
    public string Outline => "#FFEBF2";
    public string OutlineVariant => "#DBBAC8";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F4DDE5";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#51388B";
    // Primary Fixed
    public string PrimaryFixed => "#E9DDFF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#D0BCFF";
    public string OnPrimaryFixedVariant => "#170041";
    // Secondary Fixed
    public string SecondaryFixed => "#E9DDFF";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#D0BCFE";
    public string OnSecondaryFixedVariant => "#16033C";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFD8E8";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#FCB0D5";
    public string OnTertiaryFixedVariant => "#2A001A";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#291C22";
    public string SurfaceContainer => "#3B2C33";
    public string SurfaceContainerHigh => "#46373E";
    public string SurfaceContainerHighest => "#524249";
}
