using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFD2CD";
    public string OnPrimary => "#481310";
    public string PrimaryContainer => "#CC7B72";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FED2CD";
    public string OnSecondary => "#381F1C";
    public string SecondaryContainer => "#AD8883";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#F7D9A0";
    public string OnTertiary => "#332300";
    public string TertiaryContainer => "#A78D5B";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#1A1110";
    public string SurfaceVariant => "#534341";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#EED7D4";
    public string SurfaceDim => "#1A1110";
    public string SurfaceBright => "#4D4240";
    public string SurfaceTint => "#FFB4AB";
    // Background
    public string Background => "#1A1110";
    public string OnBackground => "#F1DEDC";
    // Outline
    public string Outline => "#C2ADAA";
    public string OutlineVariant => "#A08C89";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F1DEDC";
    public string InverseOnSurface => "#322826";
    public string InversePrimary => "#74352F";
    // Primary Fixed
    public string PrimaryFixed => "#FFDAD6";
    public string OnPrimaryFixed => "#2C0102";
    public string PrimaryFixedDim => "#FFB4AB";
    public string OnPrimaryFixedVariant => "#5E231E";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDAD6";
    public string OnSecondaryFixed => "#200B09";
    public string SecondaryFixedDim => "#E7BDB8";
    public string OnSecondaryFixedVariant => "#4B2F2C";
    // Tertiary Fixed
    public string TertiaryFixed => "#FDDFA6";
    public string OnTertiaryFixed => "#191000";
    public string TertiaryFixedDim => "#E0C38C";
    public string OnTertiaryFixedVariant => "#453309";
    // Surface Container
    public string SurfaceContainerLowest => "#0D0605";
    public string SurfaceContainerLow => "#251B1A";
    public string SurfaceContainer => "#302524";
    public string SurfaceContainerHigh => "#3B302F";
    public string SurfaceContainerHighest => "#463B3A";
}
