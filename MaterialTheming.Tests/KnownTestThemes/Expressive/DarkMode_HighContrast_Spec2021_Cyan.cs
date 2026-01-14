using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFEECB";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#E3BF5E";
    public string OnPrimaryContainer => "#100A00";
    // Secondary
    public string Secondary => "#F5EDFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#CABCE4";
    public string OnSecondaryContainer => "#0F0524";
    // Tertiary
    public string Tertiary => "#DCF4FF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#8FCBE4";
    public string OnTertiaryContainer => "#000D13";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#0D1418";
    public string SurfaceVariant => "#3B494F";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#0D1418";
    public string SurfaceBright => "#495155";
    public string SurfaceTint => "#E7C361";
    // Background
    public string Background => "#0D1418";
    public string OnBackground => "#DCE4E8";
    // Outline
    public string Outline => "#E3F2FA";
    public string OutlineVariant => "#B6C5CD";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#DCE4E8";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#5A4500";
    // Primary Fixed
    public string PrimaryFixed => "#FFDF90";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#E7C361";
    public string OnPrimaryFixedVariant => "#181000";
    // Secondary Fixed
    public string SecondaryFixed => "#EADDFF";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#CEC0E8";
    public string OnSecondaryFixedVariant => "#150B2A";
    // Tertiary Fixed
    public string TertiaryFixed => "#BAEAFF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#93CFE8";
    public string OnTertiaryFixedVariant => "#00141B";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#192124";
    public string SurfaceContainer => "#2A3235";
    public string SurfaceContainerHigh => "#353D40";
    public string SurfaceContainerHighest => "#40484C";
}
