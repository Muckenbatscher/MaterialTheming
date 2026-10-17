namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2025_Watch_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FEFFFF";
    public string OnPrimary => "#002126";
    public string PrimaryContainer => "#2692A2";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFEFF";
    public string OnSecondary => "#212100";
    public string SecondaryContainer => "#898857";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#100600";
    public string TertiaryContainer => "#EEA43E";
    public string OnTertiaryContainer => "#3B2200";
    // Error
    public string Error => "#FFBEB9";
    public string OnError => "#3D0004";
    public string ErrorContainer => "#CE6762";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#072A2F";
    public string OnSurface => "#FEFFFF";
    public string OnSurfaceVariant => "#C0D1D5";
    public string SurfaceDim => "#021013";
    public string SurfaceBright => "#083137";
    public string SurfaceTint => "#FEFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#98A9AC";
    public string OutlineVariant => "#78898C";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EDFCFF";
    public string InverseOnSurface => "#2B3B3E";
    public string InversePrimary => "#003F47";
    // Primary Fixed
    public string PrimaryFixed => "#8FEEFF";
    public string OnPrimaryFixed => "#002126";
    public string PrimaryFixedDim => "#80E0F0";
    public string OnPrimaryFixedVariant => "#00444D";
    // Secondary Fixed
    public string SecondaryFixed => "#E8E5AC";
    public string OnSecondaryFixed => "#212100";
    public string SecondaryFixedDim => "#D9D79F";
    public string OnSecondaryFixedVariant => "#424117";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFC47C";
    public string OnTertiaryFixed => "#100600";
    public string TertiaryFixedDim => "#FEB14B";
    public string OnTertiaryFixedVariant => "#492C00";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#18282B";
    public string SurfaceContainer => "#233336";
    public string SurfaceContainerHigh => "#2E3E41";
    public string SurfaceContainerHighest => "#072A2F";
}
