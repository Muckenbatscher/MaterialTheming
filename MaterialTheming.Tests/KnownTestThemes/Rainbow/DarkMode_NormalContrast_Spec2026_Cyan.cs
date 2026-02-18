namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class DarkMode_NormalContrast_Spec2026_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#50D8EC";
    public string OnPrimary => "#00363D";
    public string PrimaryContainer => "#004F58";
    public string OnPrimaryContainer => "#9AF0FF";
    // Secondary
    public string Secondary => "#B1CBD0";
    public string OnSecondary => "#1C3438";
    public string SecondaryContainer => "#334B4F";
    public string OnSecondaryContainer => "#CDE7EC";
    // Tertiary
    public string Tertiary => "#BBC6EA";
    public string OnTertiary => "#252F4D";
    public string TertiaryContainer => "#3B4665";
    public string OnTertiaryContainer => "#DAE2FF";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#131313";
    public string SurfaceVariant => "#474747";
    public string OnSurface => "#E2E2E2";
    public string OnSurfaceVariant => "#C6C6C6";
    public string SurfaceDim => "#131313";
    public string SurfaceBright => "#393939";
    public string SurfaceTint => "#50D8EC";
    // Background
    public string Background => "#131313";
    public string OnBackground => "#E2E2E2";
    // Outline
    public string Outline => "#919191";
    public string OutlineVariant => "#474747";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E2E2E2";
    public string InverseOnSurface => "#303030";
    public string InversePrimary => "#006875";
    // Primary Fixed
    public string PrimaryFixed => "#9AF0FF";
    public string OnPrimaryFixed => "#001F24";
    public string PrimaryFixedDim => "#50D8EC";
    public string OnPrimaryFixedVariant => "#004F58";
    // Secondary Fixed
    public string SecondaryFixed => "#CDE7EC";
    public string OnSecondaryFixed => "#051F23";
    public string SecondaryFixedDim => "#B1CBD0";
    public string OnSecondaryFixedVariant => "#334B4F";
    // Tertiary Fixed
    public string TertiaryFixed => "#DAE2FF";
    public string OnTertiaryFixed => "#0F1A37";
    public string TertiaryFixedDim => "#BBC6EA";
    public string OnTertiaryFixedVariant => "#3B4665";
    // Surface Container
    public string SurfaceContainerLowest => "#0E0E0E";
    public string SurfaceContainerLow => "#1B1B1B";
    public string SurfaceContainer => "#1F1F1F";
    public string SurfaceContainerHigh => "#2A2A2A";
    public string SurfaceContainerHighest => "#353535";
}
