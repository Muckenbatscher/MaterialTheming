namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2025_Watch_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#50B3C3";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#AAA874";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#EEA43E";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFBEB9";
    public string OnError => "#000000";
    public string ErrorContainer => "#F58680";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#072A2F";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FEFFFF";
    public string SurfaceDim => "#021013";
    public string SurfaceBright => "#083137";
    public string SurfaceTint => "#FFFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#C0D1D5";
    public string OutlineVariant => "#98A9AC";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EDFCFF";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#000000";
    // Primary Fixed
    public string PrimaryFixed => "#8FEEFF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#80E0F0";
    public string OnPrimaryFixedVariant => "#002126";
    // Secondary Fixed
    public string SecondaryFixed => "#E8E5AC";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#D9D79F";
    public string OnSecondaryFixedVariant => "#212100";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFC47C";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#FEB14B";
    public string OnTertiaryFixedVariant => "#100600";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#18282B";
    public string SurfaceContainer => "#233336";
    public string SurfaceContainerHigh => "#2E3E41";
    public string SurfaceContainerHighest => "#072A2F";
}
