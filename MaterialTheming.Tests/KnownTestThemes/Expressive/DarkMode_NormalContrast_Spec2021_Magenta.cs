namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#81D1F6";
    public string OnPrimary => "#003547";
    public string PrimaryContainer => "#004D65";
    public string OnPrimaryContainer => "#BFE9FF";
    // Secondary
    public string Secondary => "#F5B8A7";
    public string OnSecondary => "#4C261A";
    public string SecondaryContainer => "#663C2F";
    public string OnSecondaryContainer => "#FFDBD1";
    // Tertiary
    public string Tertiary => "#CCCA7F";
    public string OnTertiary => "#333200";
    public string TertiaryContainer => "#4A490A";
    public string OnTertiaryContainer => "#E9E698";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#1B1013";
    public string SurfaceVariant => "#564145";
    public string OnSurface => "#F3DDE0";
    public string OnSurfaceVariant => "#DDBFC4";
    public string SurfaceDim => "#1B1013";
    public string SurfaceBright => "#433638";
    public string SurfaceTint => "#81D1F6";
    // Background
    public string Background => "#1B1013";
    public string OnBackground => "#F3DDE0";
    // Outline
    public string Outline => "#A58A8F";
    public string OutlineVariant => "#564145";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F3DDE0";
    public string InverseOnSurface => "#3A2D2F";
    public string InversePrimary => "#006685";
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
    public string SurfaceContainerLowest => "#160B0E";
    public string SurfaceContainerLow => "#24191B";
    public string SurfaceContainer => "#281C1F";
    public string SurfaceContainerHigh => "#332729";
    public string SurfaceContainerHighest => "#3F3134";
}
