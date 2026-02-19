namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2026_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFC0DD";
    public string OnPrimary => "#6D3453";
    public string PrimaryContainer => "#F9ADD2";
    public string OnPrimaryContainer => "#622B4A";
    // Secondary
    public string Secondary => "#B0CCC8";
    public string OnSecondary => "#2C4542";
    public string SecondaryContainer => "#102A28";
    public string OnSecondaryContainer => "#8EA9A6";
    // Tertiary
    public string Tertiary => "#89FFED";
    public string OnTertiary => "#006258";
    public string TertiaryContainer => "#6EF2DF";
    public string OnTertiaryContainer => "#00594F";
    // Error
    public string Error => "#FD6F85";
    public string OnError => "#490013";
    public string ErrorContainer => "#8A1632";
    public string OnErrorContainer => "#FF97A3";
    // Surface
    public string Surface => "#190911";
    public string SurfaceVariant => "#3A1C2C";
    public string OnSurface => "#FFDCEA";
    public string OnSurfaceVariant => "#CC9FB3";
    public string SurfaceDim => "#190911";
    public string SurfaceBright => "#432133";
    public string SurfaceTint => "#FFC0DD";
    // Background
    public string Background => "#190911";
    public string OnBackground => "#FFDCEA";
    // Outline
    public string Outline => "#926A7D";
    public string OutlineVariant => "#603D4F";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F8";
    public string InverseOnSurface => "#664F59";
    public string InversePrimary => "#884B6C";
    // Primary Fixed
    public string PrimaryFixed => "#F9ADD2";
    public string OnPrimaryFixed => "#4A1735";
    public string PrimaryFixedDim => "#EAA0C4";
    public string OnPrimaryFixedVariant => "#6D3453";
    // Secondary Fixed
    public string SecondaryFixed => "#DAF7F2";
    public string OnSecondaryFixed => "#334D4A";
    public string SecondaryFixedDim => "#CCE8E4";
    public string OnSecondaryFixedVariant => "#506966";
    // Tertiary Fixed
    public string TertiaryFixed => "#6EF2DF";
    public string OnTertiaryFixed => "#00443D";
    public string TertiaryFixedDim => "#5EE3D1";
    public string OnTertiaryFixedVariant => "#006359";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#200D17";
    public string SurfaceContainer => "#29121E";
    public string SurfaceContainerHigh => "#311725";
    public string SurfaceContainerHighest => "#3A1C2C";
}
