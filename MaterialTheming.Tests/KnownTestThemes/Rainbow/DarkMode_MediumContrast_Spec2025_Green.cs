namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class DarkMode_MediumContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#9DEFA4";
    public string OnPrimary => "#002D0D";
    public string PrimaryContainer => "#53A15F";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#CEE2CB";
    public string OnSecondary => "#19291A";
    public string SecondaryContainer => "#839681";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#B7E4ED";
    public string OnTertiary => "#002A30";
    public string TertiaryContainer => "#6C98A0";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#131313";
    public string SurfaceVariant => "#474747";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DCDCDC";
    public string SurfaceDim => "#131313";
    public string SurfaceBright => "#444444";
    public string SurfaceTint => "#88D990";
    // Background
    public string Background => "#131313";
    public string OnBackground => "#E2E2E2";
    // Outline
    public string Outline => "#B2B2B2";
    public string OutlineVariant => "#909090";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E2E2E2";
    public string InverseOnSurface => "#2A2A2A";
    public string InversePrimary => "#00541F";
    // Primary Fixed
    public string PrimaryFixed => "#A3F5AA";
    public string OnPrimaryFixed => "#001504";
    public string PrimaryFixedDim => "#88D990";
    public string OnPrimaryFixedVariant => "#004016";
    // Secondary Fixed
    public string SecondaryFixed => "#D4E8D1";
    public string OnSecondaryFixed => "#051407";
    public string SecondaryFixedDim => "#B8CCB5";
    public string OnSecondaryFixedVariant => "#2A3A2A";
    // Tertiary Fixed
    public string TertiaryFixed => "#BDEAF3";
    public string OnTertiaryFixed => "#001417";
    public string TertiaryFixedDim => "#A1CED6";
    public string OnTertiaryFixedVariant => "#083C43";
    // Surface Container
    public string SurfaceContainerLowest => "#070707";
    public string SurfaceContainerLow => "#1D1D1D";
    public string SurfaceContainer => "#282828";
    public string SurfaceContainerHigh => "#323232";
    public string SurfaceContainerHighest => "#3E3E3E";
}
