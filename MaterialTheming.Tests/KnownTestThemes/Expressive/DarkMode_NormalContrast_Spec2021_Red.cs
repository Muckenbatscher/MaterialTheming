namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#ACC7FF";
    public string OnPrimary => "#002F67";
    public string PrimaryContainer => "#22467F";
    public string OnPrimaryContainer => "#D7E2FF";
    // Secondary
    public string Secondary => "#C4CB97";
    public string OnSecondary => "#2D330D";
    public string SecondaryContainer => "#444A22";
    public string OnSecondaryContainer => "#E0E7B1";
    // Tertiary
    public string Tertiary => "#A7D29E";
    public string OnTertiary => "#133813";
    public string TertiaryContainer => "#2A4F27";
    public string OnTertiaryContainer => "#C3EEB8";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#1C110D";
    public string SurfaceVariant => "#58423A";
    public string OnSurface => "#F5DED6";
    public string OnSurfaceVariant => "#DFC0B5";
    public string SurfaceDim => "#1C110D";
    public string SurfaceBright => "#443631";
    public string SurfaceTint => "#ACC7FF";
    // Background
    public string Background => "#1C110D";
    public string OnBackground => "#F5DED6";
    // Outline
    public string Outline => "#A78B81";
    public string OutlineVariant => "#58423A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F5DED6";
    public string InverseOnSurface => "#3B2D28";
    public string InversePrimary => "#3D5E98";
    // Primary Fixed
    public string PrimaryFixed => "#D7E2FF";
    public string OnPrimaryFixed => "#001A40";
    public string PrimaryFixedDim => "#ACC7FF";
    public string OnPrimaryFixedVariant => "#22467F";
    // Secondary Fixed
    public string SecondaryFixed => "#E0E7B1";
    public string OnSecondaryFixed => "#191E00";
    public string SecondaryFixedDim => "#C4CB97";
    public string OnSecondaryFixedVariant => "#444A22";
    // Tertiary Fixed
    public string TertiaryFixed => "#C3EEB8";
    public string OnTertiaryFixed => "#002203";
    public string TertiaryFixedDim => "#A7D29E";
    public string OnTertiaryFixedVariant => "#2A4F27";
    // Surface Container
    public string SurfaceContainerLowest => "#160C08";
    public string SurfaceContainerLow => "#251914";
    public string SurfaceContainer => "#291D18";
    public string SurfaceContainerHigh => "#342722";
    public string SurfaceContainerHighest => "#40322D";
}
