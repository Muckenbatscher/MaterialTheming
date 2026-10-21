namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2026_Watch_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#DD8DB6";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#80AEAC";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#57E0D6";
    public string OnTertiaryContainer => "#001C1A";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#000000";
    public string ErrorContainer => "#F38593";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#371E2B";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFEFF";
    public string SurfaceDim => "#170A11";
    public string SurfaceBright => "#402332";
    public string SurfaceTint => "#FFFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#E2C7D1";
    public string OutlineVariant => "#B89FA9";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F8";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#000000";
    // Primary Fixed
    public string PrimaryFixed => "#FFBCDB";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FCA8D1";
    public string OnPrimaryFixedVariant => "#1A000F";
    // Secondary Fixed
    public string SecondaryFixed => "#BBECE9";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#AEDDDB";
    public string OnSecondaryFixedVariant => "#002423";
    // Tertiary Fixed
    public string TertiaryFixed => "#77FDF2";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#67EFE4";
    public string OnTertiaryFixedVariant => "#002927";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#312129";
    public string SurfaceContainer => "#3D2C33";
    public string SurfaceContainerHigh => "#48363E";
    public string SurfaceContainerHighest => "#371E2B";
}
