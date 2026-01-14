using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#F0D5E0";
    public string OnPrimary => "#312129";
    public string PrimaryContainer => "#A28B94";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#EAD8DE";
    public string OnSecondary => "#2D2327";
    public string SecondaryContainer => "#9C8D92";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#F6D3E1";
    public string OnTertiary => "#351F2A";
    public string TertiaryContainer => "#A78896";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#151314";
    public string SurfaceVariant => "#4A4647";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E2DBDB";
    public string SurfaceDim => "#151314";
    public string SurfaceBright => "#474344";
    public string SurfaceTint => "#DAC0CA";
    // Background
    public string Background => "#151314";
    public string OnBackground => "#E8E1E1";
    // Outline
    public string Outline => "#B7B0B1";
    public string OutlineVariant => "#948F90";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E8E1E1";
    public string InverseOnSurface => "#2C292A";
    public string InversePrimary => "#55434B";
    // Primary Fixed
    public string PrimaryFixed => "#F7DBE6";
    public string OnPrimaryFixed => "#1B0D14";
    public string PrimaryFixedDim => "#DAC0CA";
    public string OnPrimaryFixedVariant => "#433139";
    // Secondary Fixed
    public string SecondaryFixed => "#F1DEE4";
    public string OnSecondaryFixed => "#180E13";
    public string SecondaryFixedDim => "#D4C2C8";
    public string OnSecondaryFixedVariant => "#3F3338";
    // Tertiary Fixed
    public string TertiaryFixed => "#FDD9E8";
    public string OnTertiaryFixed => "#1E0B15";
    public string TertiaryFixedDim => "#E0BDCC";
    public string OnTertiaryFixedVariant => "#472F3A";
    // Surface Container
    public string SurfaceContainerLowest => "#090708";
    public string SurfaceContainerLow => "#201D1E";
    public string SurfaceContainer => "#2A2728";
    public string SurfaceContainerHigh => "#353233";
    public string SurfaceContainerHighest => "#403D3E";
}
