namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#006685";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#BFE9FF";
    public string OnPrimaryContainer => "#004D65";
    // Secondary
    public string Secondary => "#815345";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FFDBD1";
    public string OnSecondaryContainer => "#663C2F";
    // Tertiary
    public string Tertiary => "#626122";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#E9E698";
    public string OnTertiaryContainer => "#4A490A";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FFF8F7";
    public string SurfaceVariant => "#FADBE0";
    public string OnSurface => "#24191B";
    public string OnSurfaceVariant => "#564145";
    public string SurfaceDim => "#EAD5D8";
    public string SurfaceBright => "#FFF8F7";
    public string SurfaceTint => "#006685";
    // Background
    public string Background => "#FFF8F7";
    public string OnBackground => "#24191B";
    // Outline
    public string Outline => "#8A7175";
    public string OutlineVariant => "#DDBFC4";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#3A2D2F";
    public string InverseOnSurface => "#FFECEE";
    public string InversePrimary => "#81D1F6";
    // Primary Fixed
    public string PrimaryFixed => "#BFE9FF";
    public string OnPrimaryFixed => "#001F2A";
    public string PrimaryFixedDim => "#81D1F6";
    public string OnPrimaryFixedVariant => "#004D65";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDBD1";
    public string OnSecondaryFixed => "#321208";
    public string SecondaryFixedDim => "#F5B8A7";
    public string OnSecondaryFixedVariant => "#663C2F";
    // Tertiary Fixed
    public string TertiaryFixed => "#E9E698";
    public string OnTertiaryFixed => "#1D1D00";
    public string TertiaryFixedDim => "#CCCA7F";
    public string OnTertiaryFixedVariant => "#4A490A";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F1";
    public string SurfaceContainer => "#FFE9EB";
    public string SurfaceContainerHigh => "#F9E3E6";
    public string SurfaceContainerHighest => "#F3DDE0";
}
