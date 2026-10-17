namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2025_Watch_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#8FEEFF";
    public string OnPrimary => "#00444D";
    public string PrimaryContainer => "#004F58";
    public string OnPrimaryContainer => "#90EEFF";
    // Secondary
    public string Secondary => "#E8E5AC";
    public string OnSecondary => "#424117";
    public string SecondaryContainer => "#49491E";
    public string OnSecondaryContainer => "#E5E3AA";
    // Tertiary
    public string Tertiary => "#FFC47C";
    public string OnTertiary => "#492C00";
    public string TertiaryContainer => "#EEA43E";
    public string OnTertiaryContainer => "#3B2200";
    // Error
    public string Error => "#FFBEB9";
    public string OnError => "#3F0004";
    public string ErrorContainer => "#7E2A29";
    public string OnErrorContainer => "#FFD7D4";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#072A2F";
    public string OnSurface => "#DAEBEF";
    public string OnSurfaceVariant => "#C0D1D5";
    public string SurfaceDim => "#021013";
    public string SurfaceBright => "#083137";
    public string SurfaceTint => "#8FEEFF";
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
    public string InverseOnSurface => "#48585B";
    public string InversePrimary => "#005E69";
    // Primary Fixed
    public string PrimaryFixed => "#8FEEFF";
    public string OnPrimaryFixed => "#00444D";
    public string PrimaryFixedDim => "#80E0F0";
    public string OnPrimaryFixedVariant => "#004F58";
    // Secondary Fixed
    public string SecondaryFixed => "#E8E5AC";
    public string OnSecondaryFixed => "#424117";
    public string SecondaryFixedDim => "#D9D79F";
    public string OnSecondaryFixedVariant => "#49491E";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFC47C";
    public string OnTertiaryFixed => "#492C00";
    public string TertiaryFixedDim => "#FEB14B";
    public string OnTertiaryFixedVariant => "#653E00";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#18282B";
    public string SurfaceContainer => "#233336";
    public string SurfaceContainerHigh => "#2E3E41";
    public string SurfaceContainerHighest => "#072A2F";
}
