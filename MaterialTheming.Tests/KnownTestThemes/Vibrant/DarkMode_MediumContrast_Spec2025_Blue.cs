using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#8DBBFF";
    public string OnPrimary => "#002C58";
    public string PrimaryContainer => "#5BA2FF";
    public string OnPrimaryContainer => "#00142E";
    // Secondary
    public string Secondary => "#9DB7FF";
    public string OnSecondary => "#002868";
    public string SecondaryContainer => "#4570D2";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#EAA5FF";
    public string OnTertiary => "#51066B";
    public string TertiaryContainer => "#E094F8";
    public string OnTertiaryContainer => "#420059";
    // Error
    public string Error => "#FF9F99";
    public string OnError => "#60000A";
    public string ErrorContainer => "#D7383B";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#000C2B";
    public string SurfaceVariant => "#082355";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#A9B8E3";
    public string SurfaceDim => "#000C2B";
    public string SurfaceBright => "#0D295F";
    public string SurfaceTint => "#8DBBFF";
    // Background
    public string Background => "#000C2B";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#8493BC";
    public string OutlineVariant => "#66759C";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FAF8FF";
    public string InverseOnSurface => "#29375B";
    public string InversePrimary => "#0055A0";
    // Primary Fixed
    public string PrimaryFixed => "#5BA2FF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#3594FF";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#C2D1FF";
    public string OnSecondaryFixed => "#000B29";
    public string SecondaryFixedDim => "#ADC3FF";
    public string OnSecondaryFixedVariant => "#002F79";
    // Tertiary Fixed
    public string TertiaryFixed => "#E094F8";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#D187E9";
    public string OnTertiaryFixedVariant => "#2D003E";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#001136";
    public string SurfaceContainer => "#011742";
    public string SurfaceContainerHigh => "#041D4B";
    public string SurfaceContainerHighest => "#082355";
}
