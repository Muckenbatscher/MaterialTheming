namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class DarkMode_HighContrast_Spec2026_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#CEF7FF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#4AD4E8";
    public string OnPrimaryContainer => "#000E10";
    // Secondary
    public string Secondary => "#DAF5FA";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#ADC7CC";
    public string OnSecondaryContainer => "#000E10";
    // Tertiary
    public string Tertiary => "#EDEFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#B7C2E6";
    public string OnTertiaryContainer => "#000926";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#131313";
    public string SurfaceVariant => "#474747";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#131313";
    public string SurfaceBright => "#505050";
    public string SurfaceTint => "#50D8EC";
    // Background
    public string Background => "#131313";
    public string OnBackground => "#E2E2E2";
    // Outline
    public string Outline => "#F0F0F0";
    public string OutlineVariant => "#C2C2C2";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E2E2E2";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#00505A";
    // Primary Fixed
    public string PrimaryFixed => "#9AF0FF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#50D8EC";
    public string OnPrimaryFixedVariant => "#001417";
    // Secondary Fixed
    public string SecondaryFixed => "#CDE7EC";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#B1CBD0";
    public string OnSecondaryFixedVariant => "#001417";
    // Tertiary Fixed
    public string TertiaryFixed => "#DAE2FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#BBC6EA";
    public string OnTertiaryFixedVariant => "#04102C";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1F1F1F";
    public string SurfaceContainer => "#303030";
    public string SurfaceContainerHigh => "#3B3B3B";
    public string SurfaceContainerHighest => "#474747";
}
