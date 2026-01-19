namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFB4A5";
    public string OnPrimary => "#591C10";
    public string PrimaryContainer => "#763224";
    public string OnPrimaryContainer => "#FFDAD3";
    // Secondary
    public string Secondary => "#A4D0BC";
    public string OnSecondary => "#0C3729";
    public string SecondaryContainer => "#264E3F";
    public string OnSecondaryContainer => "#C0ECD7";
    // Tertiary
    public string Tertiary => "#8CD3D1";
    public string OnTertiary => "#003736";
    public string TertiaryContainer => "#00504E";
    public string OnTertiaryContainer => "#A8EFED";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#0D1511";
    public string SurfaceVariant => "#3B4A41";
    public string OnSurface => "#DCE5DD";
    public string OnSurfaceVariant => "#BACBBF";
    public string SurfaceDim => "#0D1511";
    public string SurfaceBright => "#333B36";
    public string SurfaceTint => "#FFB4A5";
    // Background
    public string Background => "#0D1511";
    public string OnBackground => "#DCE5DD";
    // Outline
    public string Outline => "#84958A";
    public string OutlineVariant => "#3B4A41";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#DCE5DD";
    public string InverseOnSurface => "#2A322D";
    public string InversePrimary => "#944839";
    // Primary Fixed
    public string PrimaryFixed => "#FFDAD3";
    public string OnPrimaryFixed => "#3C0701";
    public string PrimaryFixedDim => "#FFB4A5";
    public string OnPrimaryFixedVariant => "#763224";
    // Secondary Fixed
    public string SecondaryFixed => "#C0ECD7";
    public string OnSecondaryFixed => "#002116";
    public string SecondaryFixedDim => "#A4D0BC";
    public string OnSecondaryFixedVariant => "#264E3F";
    // Tertiary Fixed
    public string TertiaryFixed => "#A8EFED";
    public string OnTertiaryFixed => "#00201F";
    public string TertiaryFixedDim => "#8CD3D1";
    public string OnTertiaryFixedVariant => "#00504E";
    // Surface Container
    public string SurfaceContainerLowest => "#08100C";
    public string SurfaceContainerLow => "#151D19";
    public string SurfaceContainer => "#19211D";
    public string SurfaceContainerHigh => "#232C27";
    public string SurfaceContainerHighest => "#2E3731";
}
