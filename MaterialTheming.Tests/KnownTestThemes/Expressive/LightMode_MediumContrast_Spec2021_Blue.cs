using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#163F08";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#4D783B";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#4E2B3D";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#8B6175";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#273460";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#5F6B9B";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FAF8FF";
    public string SurfaceVariant => "#E0E1F3";
    public string OnSurface => "#0F1118";
    public string OnSurfaceVariant => "#333643";
    public string SurfaceDim => "#C6C5D0";
    public string SurfaceBright => "#FAF8FF";
    public string SurfaceTint => "#3E692E";
    // Background
    public string Background => "#FAF8FF";
    public string OnBackground => "#1A1B23";
    // Outline
    public string Outline => "#4F5260";
    public string OutlineVariant => "#6A6C7B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2F3038";
    public string InverseOnSurface => "#F1F0FA";
    public string InversePrimary => "#A3D48D";
    // Primary Fixed
    public string PrimaryFixed => "#4D783B";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#355F25";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#8B6175";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#70495C";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#5F6B9B";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#475281";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F3F2FD";
    public string SurfaceContainer => "#E8E7F2";
    public string SurfaceContainerHigh => "#DCDCE6";
    public string SurfaceContainerHighest => "#D1D1DB";
}
