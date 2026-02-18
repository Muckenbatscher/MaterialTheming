namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_NormalContrast_Spec2026_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#4FD8EB";
    public string OnPrimary => "#00363D";
    public string PrimaryContainer => "#004F58";
    public string OnPrimaryContainer => "#98F0FF";
    // Secondary
    public string Secondary => "#82D3E0";
    public string OnSecondary => "#00363D";
    public string SecondaryContainer => "#004F58";
    public string OnSecondaryContainer => "#9EEFFD";
    // Tertiary
    public string Tertiary => "#A6C8FF";
    public string OnTertiary => "#02315E";
    public string TertiaryContainer => "#234776";
    public string OnTertiaryContainer => "#D5E3FF";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#0E141C";
    public string SurfaceVariant => "#3D4758";
    public string OnSurface => "#DEE2EF";
    public string OnSurfaceVariant => "#BDC7DC";
    public string SurfaceDim => "#0E141C";
    public string SurfaceBright => "#343943";
    public string SurfaceTint => "#4FD8EB";
    // Background
    public string Background => "#0E141C";
    public string OnBackground => "#DEE2EF";
    // Outline
    public string Outline => "#8791A5";
    public string OutlineVariant => "#3D4758";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#DEE2EF";
    public string InverseOnSurface => "#2B313A";
    public string InversePrimary => "#006874";
    // Primary Fixed
    public string PrimaryFixed => "#98F0FF";
    public string OnPrimaryFixed => "#001F24";
    public string PrimaryFixedDim => "#4FD8EB";
    public string OnPrimaryFixedVariant => "#004F58";
    // Secondary Fixed
    public string SecondaryFixed => "#9EEFFD";
    public string OnSecondaryFixed => "#001F24";
    public string SecondaryFixedDim => "#82D3E0";
    public string OnSecondaryFixedVariant => "#004F58";
    // Tertiary Fixed
    public string TertiaryFixed => "#D5E3FF";
    public string OnTertiaryFixed => "#001C3B";
    public string TertiaryFixedDim => "#A6C8FF";
    public string OnTertiaryFixedVariant => "#234776";
    // Surface Container
    public string SurfaceContainerLowest => "#090E17";
    public string SurfaceContainerLow => "#171C24";
    public string SurfaceContainer => "#1B2029";
    public string SurfaceContainerHigh => "#252A33";
    public string SurfaceContainerHighest => "#30353E";
}
