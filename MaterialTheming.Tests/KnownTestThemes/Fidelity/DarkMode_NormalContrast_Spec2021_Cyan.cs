namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class DarkMode_NormalContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#45D8EE";
    public string OnPrimary => "#00363D";
    public string PrimaryContainer => "#00BCD1";
    public string OnPrimaryContainer => "#00464F";
    // Secondary
    public string Secondary => "#9FCED7";
    public string OnSecondary => "#00363D";
    public string SecondaryContainer => "#1C4D55";
    public string OnSecondaryContainer => "#8EBDC6";
    // Tertiary
    public string Tertiary => "#FFB781";
    public string OnTertiary => "#4E2500";
    public string TertiaryContainer => "#F39445";
    public string OnTertiaryContainer => "#653200";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#0E1416";
    public string SurfaceVariant => "#3C494B";
    public string OnSurface => "#DDE4E5";
    public string OnSurfaceVariant => "#BBC9CC";
    public string SurfaceDim => "#0E1416";
    public string SurfaceBright => "#343A3C";
    public string SurfaceTint => "#45D8EE";
    // Background
    public string Background => "#0E1416";
    public string OnBackground => "#DDE4E5";
    // Outline
    public string Outline => "#869396";
    public string OutlineVariant => "#3C494B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#DDE4E5";
    public string InverseOnSurface => "#2B3133";
    public string InversePrimary => "#006875";
    // Primary Fixed
    public string PrimaryFixed => "#9AF0FF";
    public string OnPrimaryFixed => "#001F24";
    public string PrimaryFixedDim => "#45D8EE";
    public string OnPrimaryFixedVariant => "#004F58";
    // Secondary Fixed
    public string SecondaryFixed => "#BBEBF4";
    public string OnSecondaryFixed => "#001F24";
    public string SecondaryFixedDim => "#9FCED7";
    public string OnSecondaryFixedVariant => "#1C4D55";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDCC4";
    public string OnTertiaryFixed => "#2F1400";
    public string TertiaryFixedDim => "#FFB781";
    public string OnTertiaryFixedVariant => "#703800";
    // Surface Container
    public string SurfaceContainerLowest => "#090F10";
    public string SurfaceContainerLow => "#161D1E";
    public string SurfaceContainer => "#1A2122";
    public string SurfaceContainerHigh => "#252B2C";
    public string SurfaceContainerHighest => "#2F3637";
}
