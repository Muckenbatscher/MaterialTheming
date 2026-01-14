using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_MediumContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#F5DC60";
    public string OnPrimary => "#2C2500";
    public string PrimaryContainer => "#A59016";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#F0DD83";
    public string OnSecondary => "#2C2500";
    public string SecondaryContainer => "#A19140";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#B2EAB3";
    public string OnTertiary => "#002D0D";
    public string TertiaryContainer => "#689D6C";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#0D150D";
    public string SurfaceVariant => "#3A4B3A";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#CEE2CB";
    public string SurfaceDim => "#0D150D";
    public string SurfaceBright => "#3E473D";
    public string SurfaceTint => "#DEC74C";
    // Background
    public string Background => "#0D150D";
    public string OnBackground => "#DBE5D7";
    // Outline
    public string Outline => "#A4B7A1";
    public string OutlineVariant => "#829581";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#DBE5D7";
    public string InverseOnSurface => "#232C23";
    public string InversePrimary => "#534800";
    // Primary Fixed
    public string PrimaryFixed => "#FCE365";
    public string OnPrimaryFixed => "#151100";
    public string PrimaryFixedDim => "#DEC74C";
    public string OnPrimaryFixedVariant => "#3F3600";
    // Secondary Fixed
    public string SecondaryFixed => "#F6E388";
    public string OnSecondaryFixed => "#151100";
    public string SecondaryFixedDim => "#D9C76F";
    public string OnSecondaryFixedVariant => "#3F3600";
    // Tertiary Fixed
    public string TertiaryFixed => "#B8F1B9";
    public string OnTertiaryFixed => "#001504";
    public string TertiaryFixedDim => "#9CD49F";
    public string OnTertiaryFixedVariant => "#083F18";
    // Surface Container
    public string SurfaceContainerLowest => "#030903";
    public string SurfaceContainerLow => "#172017";
    public string SurfaceContainer => "#212A21";
    public string SurfaceContainerHigh => "#2C352B";
    public string SurfaceContainerHighest => "#374036";
}
