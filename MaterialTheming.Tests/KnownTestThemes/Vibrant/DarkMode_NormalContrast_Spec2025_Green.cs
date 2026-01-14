using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#63FC85";
    public string OnPrimary => "#005D24";
    public string PrimaryContainer => "#02BF51";
    public string OnPrimaryContainer => "#002F0E";
    // Secondary
    public string Secondary => "#7AF8B1";
    public string OnSecondary => "#005C37";
    public string SecondaryContainer => "#006D42";
    public string OnSecondaryContainer => "#E2FFE8";
    // Tertiary
    public string Tertiary => "#86ECFF";
    public string OnTertiary => "#005762";
    public string TertiaryContainer => "#00E3FF";
    public string OnTertiaryContainer => "#004D58";
    // Error
    public string Error => "#FF7351";
    public string OnError => "#450900";
    public string ErrorContainer => "#B92902";
    public string OnErrorContainer => "#FFD2C8";
    // Surface
    public string Surface => "#001207";
    public string SurfaceVariant => "#002D18";
    public string OnSurface => "#CBFCDA";
    public string OnSurfaceVariant => "#87B697";
    public string SurfaceDim => "#001207";
    public string SurfaceBright => "#00341D";
    public string SurfaceTint => "#63FC85";
    // Background
    public string Background => "#001207";
    public string OnBackground => "#CBFCDA";
    // Outline
    public string Outline => "#527F63";
    public string OutlineVariant => "#245037";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E9FFED";
    public string InverseOnSurface => "#325E44";
    public string InversePrimary => "#006E2C";
    // Primary Fixed
    public string PrimaryFixed => "#63FC85";
    public string OnPrimaryFixed => "#00481A";
    public string PrimaryFixedDim => "#53ED79";
    public string OnPrimaryFixedVariant => "#006829";
    // Secondary Fixed
    public string SecondaryFixed => "#7AF8B1";
    public string OnSecondaryFixed => "#00472A";
    public string SecondaryFixedDim => "#6BE9A4";
    public string OnSecondaryFixedVariant => "#00673E";
    // Tertiary Fixed
    public string TertiaryFixed => "#00E3FF";
    public string OnTertiaryFixed => "#003840";
    public string TertiaryFixedDim => "#00D4EE";
    public string OnTertiaryFixedVariant => "#005763";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#00180A";
    public string SurfaceContainer => "#001F0F";
    public string SurfaceContainerHigh => "#002613";
    public string SurfaceContainerHighest => "#002D18";
}
