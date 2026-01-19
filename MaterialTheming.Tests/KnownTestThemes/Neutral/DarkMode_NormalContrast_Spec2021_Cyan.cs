namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#B8CACD";
    public string OnPrimary => "#233336";
    public string PrimaryContainer => "#39494D";
    public string OnPrimaryContainer => "#D4E6E9";
    // Secondary
    public string Secondary => "#BFC8CA";
    public string OnSecondary => "#293234";
    public string SecondaryContainer => "#3F484A";
    public string OnSecondaryContainer => "#DBE4E6";
    // Tertiary
    public string Tertiary => "#B1CBD0";
    public string OnTertiary => "#1C3438";
    public string TertiaryContainer => "#334B4F";
    public string OnTertiaryContainer => "#CDE7EC";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#121414";
    public string SurfaceVariant => "#464747";
    public string OnSurface => "#E3E2E2";
    public string OnSurfaceVariant => "#C7C6C6";
    public string SurfaceDim => "#121414";
    public string SurfaceBright => "#383939";
    public string SurfaceTint => "#B8CACD";
    // Background
    public string Background => "#121414";
    public string OnBackground => "#E3E2E2";
    // Outline
    public string Outline => "#919191";
    public string OutlineVariant => "#464747";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E3E2E2";
    public string InverseOnSurface => "#2F3031";
    public string InversePrimary => "#516164";
    // Primary Fixed
    public string PrimaryFixed => "#D4E6E9";
    public string OnPrimaryFixed => "#0E1E21";
    public string PrimaryFixedDim => "#B8CACD";
    public string OnPrimaryFixedVariant => "#39494D";
    // Secondary Fixed
    public string SecondaryFixed => "#DBE4E6";
    public string OnSecondaryFixed => "#141D1F";
    public string SecondaryFixedDim => "#BFC8CA";
    public string OnSecondaryFixedVariant => "#3F484A";
    // Tertiary Fixed
    public string TertiaryFixed => "#CDE7EC";
    public string OnTertiaryFixed => "#051F23";
    public string TertiaryFixedDim => "#B1CBD0";
    public string OnTertiaryFixedVariant => "#334B4F";
    // Surface Container
    public string SurfaceContainerLowest => "#0D0E0F";
    public string SurfaceContainerLow => "#1B1C1C";
    public string SurfaceContainer => "#1F2020";
    public string SurfaceContainerHigh => "#292A2A";
    public string SurfaceContainerHighest => "#343535";
}
