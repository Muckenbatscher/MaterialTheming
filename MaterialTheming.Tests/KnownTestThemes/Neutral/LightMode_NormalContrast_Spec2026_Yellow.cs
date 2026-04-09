namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2026_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#605F51";
    public string OnPrimary => "#FCF8E6";
    public string PrimaryContainer => "#E6E3D1";
    public string OnPrimaryContainer => "#535245";
    // Secondary
    public string Secondary => "#66645D";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#E6E2D9";
    public string OnSecondaryContainer => "#53524B";
    // Tertiary
    public string Tertiary => "#626844";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#F2F8CA";
    public string OnTertiaryContainer => "#595F3C";
    // Error
    public string Error => "#A54731";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FE8B70";
    public string OnErrorContainer => "#742410";
    // Surface
    public string Surface => "#FEFCFA";
    public string SurfaceVariant => "#EBE8E1";
    public string OnSurface => "#393833";
    public string OnSurfaceVariant => "#66645F";
    public string SurfaceDim => "#E6E2DA";
    public string SurfaceBright => "#FEFCFA";
    public string SurfaceTint => "#605F51";
    // Background
    public string Background => "#FEFCFA";
    public string OnBackground => "#393833";
    // Outline
    public string Outline => "#82807B";
    public string OutlineVariant => "#BCB9B3";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0F0E0D";
    public string InverseOnSurface => "#9F9C9A";
    public string InversePrimary => "#FDFAE7";
    // Primary Fixed
    public string PrimaryFixed => "#E6E3D1";
    public string OnPrimaryFixed => "#414033";
    public string PrimaryFixedDim => "#D8D5C3";
    public string OnPrimaryFixedVariant => "#5D5C4E";
    // Secondary Fixed
    public string SecondaryFixed => "#E6E2D9";
    public string OnSecondaryFixed => "#403F39";
    public string SecondaryFixedDim => "#D8D4CC";
    public string OnSecondaryFixedVariant => "#5D5B55";
    // Tertiary Fixed
    public string TertiaryFixed => "#F2F8CA";
    public string OnTertiaryFixed => "#474D2B";
    public string TertiaryFixedDim => "#E3E9BD";
    public string OnTertiaryFixedVariant => "#636946";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FDF9F4";
    public string SurfaceContainer => "#F7F3EE";
    public string SurfaceContainerHigh => "#F1EDE7";
    public string SurfaceContainerHighest => "#EBE8E1";
}
