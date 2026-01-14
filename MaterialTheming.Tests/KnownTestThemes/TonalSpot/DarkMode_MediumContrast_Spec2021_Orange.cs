using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFD3BB";
    public string OnPrimary => "#411A00";
    public string PrimaryContainer => "#C78053";
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
    public string Surface => "#1A120D";
    public string SurfaceVariant => "#52443C";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#EED8CD";
    public string SurfaceDim => "#1A120D";
    public string SurfaceBright => "#4D423D";
    public string SurfaceTint => "#FFB68B";
    // Background
    public string Background => "#1A120D";
    public string OnBackground => "#F0DFD7";
    // Outline
    public string Outline => "#C2AEA4";
    public string OutlineVariant => "#9F8D83";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F0DFD7";
    public string InverseOnSurface => "#312823";
    public string InversePrimary => "#703912";
    // Primary Fixed
    public string PrimaryFixed => "#FFDBC8";
    public string OnPrimaryFixed => "#220A00";
    public string PrimaryFixedDim => "#FFB68B";
    public string OnPrimaryFixedVariant => "#5A2802";
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
    public string SurfaceContainerLowest => "#0C0604";
    public string SurfaceContainerLow => "#241C17";
    public string SurfaceContainer => "#2F2621";
    public string SurfaceContainerHigh => "#3A312B";
    public string SurfaceContainerHighest => "#463C36";
}
