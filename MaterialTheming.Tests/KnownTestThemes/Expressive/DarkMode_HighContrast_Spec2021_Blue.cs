using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#CCFEB3";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#A0D089";
    public string OnPrimaryContainer => "#010F00";
    // Secondary
    public string Secondary => "#FFEBF2";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#E7B5CB";
    public string OnSecondaryContainer => "#1C0311";
    // Tertiary
    public string Tertiary => "#EEEFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#B4C0F6";
    public string OnTertiaryContainer => "#00082B";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#11131A";
    public string SurfaceVariant => "#444654";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#11131A";
    public string SurfaceBright => "#4E4F58";
    public string SurfaceTint => "#A3D48D";
    // Background
    public string Background => "#11131A";
    public string OnBackground => "#E2E1EC";
    // Outline
    public string Outline => "#EEEFFF";
    public string OutlineVariant => "#C0C1D2";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E2E1EC";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#285119";
    // Primary Fixed
    public string PrimaryFixed => "#BFF0A6";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#A3D48D";
    public string OnPrimaryFixedVariant => "#021500";
    // Secondary Fixed
    public string SecondaryFixed => "#FFD8E8";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#EBB8CF";
    public string OnSecondaryFixedVariant => "#230717";
    // Tertiary Fixed
    public string TertiaryFixed => "#DCE1FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#B8C4FA";
    public string OnTertiaryFixedVariant => "#000C39";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1E1F27";
    public string SurfaceContainer => "#2F3038";
    public string SurfaceContainerHigh => "#3A3B43";
    public string SurfaceContainerHighest => "#45464F";
}
