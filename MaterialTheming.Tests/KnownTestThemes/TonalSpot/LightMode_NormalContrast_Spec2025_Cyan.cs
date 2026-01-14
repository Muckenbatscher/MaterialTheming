using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#1C6873";
    public string OnPrimary => "#ECFCFF";
    public string PrimaryContainer => "#A9EEFA";
    public string OnPrimaryContainer => "#015B65";
    // Secondary
    public string Secondary => "#4B6368";
    public string OnSecondary => "#ECFCFF";
    public string SecondaryContainer => "#CDE7EC";
    public string OnSecondaryContainer => "#3E565A";
    // Tertiary
    public string Tertiary => "#436281";
    public string OnTertiary => "#F7F9FF";
    public string TertiaryContainer => "#BADAFF";
    public string OnTertiaryContainer => "#2E4D6C";
    // Error
    public string Error => "#A83836";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#FA746F";
    public string OnErrorContainer => "#6E0A12";
    // Surface
    public string Surface => "#F6FAFB";
    public string SurfaceVariant => "#DAE4E7";
    public string OnSurface => "#2A3436";
    public string OnSurfaceVariant => "#576163";
    public string SurfaceDim => "#D1DCDE";
    public string SurfaceBright => "#F6FAFB";
    public string SurfaceTint => "#1C6873";
    // Background
    public string Background => "#F6FAFB";
    public string OnBackground => "#2A3436";
    // Outline
    public string Outline => "#727C7F";
    public string OutlineVariant => "#A9B4B6";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0A0F10";
    public string InverseOnSurface => "#999E9F";
    public string InversePrimary => "#A9EEFA";
    // Primary Fixed
    public string PrimaryFixed => "#A9EEFA";
    public string OnPrimaryFixed => "#00464F";
    public string PrimaryFixedDim => "#9BDFEC";
    public string OnPrimaryFixedVariant => "#17656F";
    // Secondary Fixed
    public string SecondaryFixed => "#CDE7EC";
    public string OnSecondaryFixed => "#2B4347";
    public string SecondaryFixedDim => "#BFD9DE";
    public string OnSecondaryFixedVariant => "#475F64";
    // Tertiary Fixed
    public string TertiaryFixed => "#BADAFF";
    public string OnTertiaryFixed => "#183A58";
    public string TertiaryFixedDim => "#ADCCF1";
    public string OnTertiaryFixedVariant => "#375776";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EEF5F6";
    public string SurfaceContainer => "#E8EFF1";
    public string SurfaceContainerHigh => "#E1EAEB";
    public string SurfaceContainerHighest => "#DAE4E7";
}
