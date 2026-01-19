namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_NormalContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#A6C8FF";
    public string OnPrimary => "#003060";
    public string PrimaryContainer => "#004787";
    public string OnPrimaryContainer => "#D5E3FF";
    // Secondary
    public string Secondary => "#A6C8FF";
    public string OnSecondary => "#03305F";
    public string SecondaryContainer => "#234776";
    public string OnSecondaryContainer => "#D5E3FF";
    // Tertiary
    public string Tertiary => "#DBB9F9";
    public string OnTertiary => "#3E2459";
    public string TertiaryContainer => "#563B71";
    public string OnTertiaryContainer => "#F0DBFF";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#16111B";
    public string SurfaceVariant => "#4D4357";
    public string OnSurface => "#EADFED";
    public string OnSurfaceVariant => "#D0C1DA";
    public string SurfaceDim => "#16111B";
    public string SurfaceBright => "#3D3742";
    public string SurfaceTint => "#A6C8FF";
    // Background
    public string Background => "#16111B";
    public string OnBackground => "#EADFED";
    // Outline
    public string Outline => "#998CA3";
    public string OutlineVariant => "#4D4357";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EADFED";
    public string InverseOnSurface => "#342E39";
    public string InversePrimary => "#215FA6";
    // Primary Fixed
    public string PrimaryFixed => "#D5E3FF";
    public string OnPrimaryFixed => "#001C3B";
    public string PrimaryFixedDim => "#A6C8FF";
    public string OnPrimaryFixedVariant => "#004787";
    // Secondary Fixed
    public string SecondaryFixed => "#D5E3FF";
    public string OnSecondaryFixed => "#001C3B";
    public string SecondaryFixedDim => "#A6C8FF";
    public string OnSecondaryFixedVariant => "#234776";
    // Tertiary Fixed
    public string TertiaryFixed => "#F0DBFF";
    public string OnTertiaryFixed => "#280D42";
    public string TertiaryFixedDim => "#DBB9F9";
    public string OnTertiaryFixedVariant => "#563B71";
    // Surface Container
    public string SurfaceContainerLowest => "#110C16";
    public string SurfaceContainerLow => "#1F1923";
    public string SurfaceContainer => "#231D28";
    public string SurfaceContainerHigh => "#2E2832";
    public string SurfaceContainerHighest => "#39323D";
}
