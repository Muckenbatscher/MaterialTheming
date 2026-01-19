namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class DarkMode_MediumContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFD3BB";
    public string OnPrimary => "#411A00";
    public string PrimaryContainer => "#D5793B";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FCD4BE";
    public string OnSecondary => "#372012";
    public string SecondaryContainer => "#AC8A76";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#E2DFA6";
    public string OnTertiary => "#282701";
    public string TertiaryContainer => "#959361";
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
    public string SurfaceTint => "#FFB68B";
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
    public string InversePrimary => "#763500";
    // Primary Fixed
    public string PrimaryFixed => "#FFDBC8";
    public string OnPrimaryFixed => "#220A00";
    public string PrimaryFixedDim => "#FFB68B";
    public string OnPrimaryFixedVariant => "#5B2700";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDBC8";
    public string OnSecondaryFixed => "#1F0C03";
    public string SecondaryFixedDim => "#E5BFA9";
    public string OnSecondaryFixedVariant => "#493121";
    // Tertiary Fixed
    public string TertiaryFixed => "#E8E5AC";
    public string OnTertiaryFixed => "#121200";
    public string TertiaryFixedDim => "#CBC992";
    public string OnTertiaryFixedVariant => "#39380E";
    // Surface Container
    public string SurfaceContainerLowest => "#070707";
    public string SurfaceContainerLow => "#1D1D1D";
    public string SurfaceContainer => "#282828";
    public string SurfaceContainerHigh => "#323232";
    public string SurfaceContainerHighest => "#3E3E3E";
}
