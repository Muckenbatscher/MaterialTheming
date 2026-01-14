using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#9CD49F";
    public string OnPrimary => "#013913";
    public string PrimaryContainer => "#1D5128";
    public string OnPrimaryContainer => "#B8F1B9";
    // Secondary
    public string Secondary => "#B8CCB5";
    public string OnSecondary => "#243424";
    public string SecondaryContainer => "#3A4B3A";
    public string OnSecondaryContainer => "#D4E8D1";
    // Tertiary
    public string Tertiary => "#A1CED6";
    public string OnTertiary => "#00363D";
    public string TertiaryContainer => "#1F4D54";
    public string OnTertiaryContainer => "#BDEAF3";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#101510";
    public string SurfaceVariant => "#424940";
    public string OnSurface => "#E0E4DB";
    public string OnSurfaceVariant => "#C1C9BE";
    public string SurfaceDim => "#101510";
    public string SurfaceBright => "#363A35";
    public string SurfaceTint => "#9CD49F";
    // Background
    public string Background => "#101510";
    public string OnBackground => "#E0E4DB";
    // Outline
    public string Outline => "#8B9389";
    public string OutlineVariant => "#424940";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E0E4DB";
    public string InverseOnSurface => "#2D322C";
    public string InversePrimary => "#36693D";
    // Primary Fixed
    public string PrimaryFixed => "#B8F1B9";
    public string OnPrimaryFixed => "#002108";
    public string PrimaryFixedDim => "#9CD49F";
    public string OnPrimaryFixedVariant => "#1D5128";
    // Secondary Fixed
    public string SecondaryFixed => "#D4E8D1";
    public string OnSecondaryFixed => "#0F1F11";
    public string SecondaryFixedDim => "#B8CCB5";
    public string OnSecondaryFixedVariant => "#3A4B3A";
    // Tertiary Fixed
    public string TertiaryFixed => "#BDEAF3";
    public string OnTertiaryFixed => "#001F24";
    public string TertiaryFixedDim => "#A1CED6";
    public string OnTertiaryFixedVariant => "#1F4D54";
    // Surface Container
    public string SurfaceContainerLowest => "#0B0F0B";
    public string SurfaceContainerLow => "#181D18";
    public string SurfaceContainer => "#1C211C";
    public string SurfaceContainerHigh => "#272B26";
    public string SurfaceContainerHighest => "#313630";
}
