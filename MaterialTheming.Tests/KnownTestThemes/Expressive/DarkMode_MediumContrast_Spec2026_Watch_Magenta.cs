namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2026_Watch_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#1A000F";
    public string PrimaryContainer => "#B96E95";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FDFFFE";
    public string OnSecondary => "#002423";
    public string SecondaryContainer => "#608E8C";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FDFFFE";
    public string OnTertiary => "#002927";
    public string TertiaryContainer => "#57E0D6";
    public string OnTertiaryContainer => "#00423E";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3D000F";
    public string ErrorContainer => "#CC6674";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#371E2B";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#E2C7D1";
    public string SurfaceDim => "#170A11";
    public string SurfaceBright => "#402332";
    public string SurfaceTint => "#FFFEFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#B89FA9";
    public string OutlineVariant => "#968089";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F8";
    public string InverseOnSurface => "#45333B";
    public string InversePrimary => "#5E2245";
    // Primary Fixed
    public string PrimaryFixed => "#FFBCDB";
    public string OnPrimaryFixed => "#1A000F";
    public string PrimaryFixedDim => "#FCA8D1";
    public string OnPrimaryFixedVariant => "#571C3F";
    // Secondary Fixed
    public string SecondaryFixed => "#BBECE9";
    public string OnSecondaryFixed => "#002423";
    public string SecondaryFixedDim => "#AEDDDB";
    public string OnSecondaryFixedVariant => "#154645";
    // Tertiary Fixed
    public string TertiaryFixed => "#77FDF2";
    public string OnTertiaryFixed => "#002927";
    public string TertiaryFixedDim => "#67EFE4";
    public string OnTertiaryFixedVariant => "#004C47";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#312129";
    public string SurfaceContainer => "#3D2C33";
    public string SurfaceContainerHigh => "#48363E";
    public string SurfaceContainerHighest => "#371E2B";
}
