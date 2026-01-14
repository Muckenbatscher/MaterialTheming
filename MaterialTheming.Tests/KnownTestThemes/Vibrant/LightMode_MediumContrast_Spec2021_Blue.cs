using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#003669";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#006DCA";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#2D3553";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#646C8D";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#34305F";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#6C679A";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F9F9FF";
    public string SurfaceVariant => "#DCE2F2";
    public string OnSurface => "#0C111A";
    public string OnSurfaceVariant => "#303642";
    public string SurfaceDim => "#C2C6D2";
    public string SurfaceBright => "#F9F9FF";
    public string SurfaceTint => "#005FB0";
    // Background
    public string Background => "#F9F9FF";
    public string OnBackground => "#171C24";
    // Outline
    public string Outline => "#4C535F";
    public string OutlineVariant => "#676D7A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2B313A";
    public string InverseOnSurface => "#ECF1FD";
    public string InversePrimary => "#A6C8FF";
    // Primary Fixed
    public string PrimaryFixed => "#006DCA";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#00559F";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#646C8D";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#4C5374";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#6C679A";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#534F80";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F0F3FF";
    public string SurfaceContainer => "#E4E8F4";
    public string SurfaceContainerHigh => "#D8DDE9";
    public string SurfaceContainerHighest => "#CDD1DE";
}
