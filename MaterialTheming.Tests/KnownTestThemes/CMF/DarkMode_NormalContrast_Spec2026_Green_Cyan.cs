namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_NormalContrast_Spec2026_Green_Cyan : ITestThemeSecondSourceColor
{
    public string SourceColor => "#338745"; //Green
    public string SecondSourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#5CAF68";
    public string OnPrimary => "#00270A";
    public string PrimaryContainer => "#308443";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#85A684";
    public string OnSecondary => "#07260E";
    public string SecondaryContainer => "#19371D";
    public string OnSecondaryContainer => "#97B996";
    // Tertiary
    public string Tertiary => "#2DCADF";
    public string OnTertiary => "#003D44";
    public string TertiaryContainer => "#00BCD1";
    public string OnTertiaryContainer => "#003138";
    // Error
    public string Error => "#FE8B70";
    public string OnError => "#5A1001";
    public string ErrorContainer => "#601503";
    public string OnErrorContainer => "#FF9379";
    // Surface
    public string Surface => "#081008";
    public string SurfaceVariant => "#182A1A";
    public string OnSurface => "#D6EBD2";
    public string OnSurfaceVariant => "#9CB19A";
    public string SurfaceDim => "#081008";
    public string SurfaceBright => "#1E3020";
    public string SurfaceTint => "#5CAF68";
    // Background
    public string Background => "#081008";
    public string OnBackground => "#D6EBD2";
    // Outline
    public string Outline => "#677B66";
    public string OutlineVariant => "#3A4D3A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EBFFE7";
    public string InverseOnSurface => "#4E584D";
    public string InversePrimary => "#136E2F";
    // Primary Fixed
    public string PrimaryFixed => "#308443";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#217737";
    public string OnPrimaryFixedVariant => "#F7FFF2";
    // Secondary Fixed
    public string SecondaryFixed => "#C8ECC6";
    public string OnSecondaryFixed => "#28462B";
    public string SecondaryFixedDim => "#BADEB9";
    public string OnSecondaryFixedVariant => "#446345";
    // Tertiary Fixed
    public string TertiaryFixed => "#00BCD1";
    public string OnTertiaryFixed => "#001316";
    public string TertiaryFixedDim => "#00ADC1";
    public string OnTertiaryFixedVariant => "#003B43";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#0B160B";
    public string SurfaceContainer => "#0F1D10";
    public string SurfaceContainerHigh => "#142315";
    public string SurfaceContainerHighest => "#182A1A";
}
