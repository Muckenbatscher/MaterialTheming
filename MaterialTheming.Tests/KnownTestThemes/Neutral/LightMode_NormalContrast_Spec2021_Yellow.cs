namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#615F4A";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#E7E3C8";
    public string OnPrimaryContainer => "#494833";
    // Secondary
    public string Secondary => "#605F51";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#E6E3D1";
    public string OnSecondaryContainer => "#48473A";
    // Tertiary
    public string Tertiary => "#616042";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#E7E4BF";
    public string OnTertiaryContainer => "#49482D";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FDF9F4";
    public string SurfaceVariant => "#E6E2DD";
    public string OnSurface => "#1C1C19";
    public string OnSurfaceVariant => "#484744";
    public string SurfaceDim => "#DDD9D5";
    public string SurfaceBright => "#FDF9F4";
    public string SurfaceTint => "#615F4A";
    // Background
    public string Background => "#FDF9F4";
    public string OnBackground => "#1C1C19";
    // Outline
    public string Outline => "#797773";
    public string OutlineVariant => "#C9C6C2";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#31302D";
    public string InverseOnSurface => "#F4F0EB";
    public string InversePrimary => "#CAC7AD";
    // Primary Fixed
    public string PrimaryFixed => "#E7E3C8";
    public string OnPrimaryFixed => "#1D1C0B";
    public string PrimaryFixedDim => "#CAC7AD";
    public string OnPrimaryFixedVariant => "#494833";
    // Secondary Fixed
    public string SecondaryFixed => "#E6E3D1";
    public string OnSecondaryFixed => "#1D1C11";
    public string SecondaryFixedDim => "#CAC7B6";
    public string OnSecondaryFixedVariant => "#48473A";
    // Tertiary Fixed
    public string TertiaryFixed => "#E7E4BF";
    public string OnTertiaryFixed => "#1D1D06";
    public string TertiaryFixedDim => "#CBC8A4";
    public string OnTertiaryFixedVariant => "#49482D";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F7F3EE";
    public string SurfaceContainer => "#F1EDE9";
    public string SurfaceContainerHigh => "#EBE7E3";
    public string SurfaceContainerHighest => "#E6E2DD";
}
