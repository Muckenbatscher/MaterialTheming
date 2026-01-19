namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#685B60";
    public string OnPrimary => "#FFF5F7";
    public string PrimaryContainer => "#F1DEE4";
    public string OnPrimaryContainer => "#5B4E53";
    // Secondary
    public string Secondary => "#655D5F";
    public string OnSecondary => "#FFF7F8";
    public string SecondaryContainer => "#EBE0E2";
    public string OnSecondaryContainer => "#575052";
    // Tertiary
    public string Tertiary => "#6B5873";
    public string OnTertiary => "#FFF7FC";
    public string TertiaryContainer => "#F6DDFD";
    public string OnTertiaryContainer => "#5F4D67";
    // Error
    public string Error => "#9E3F4E";
    public string OnError => "#FFF7F7";
    public string ErrorContainer => "#FF8B9A";
    public string OnErrorContainer => "#782232";
    // Surface
    public string Surface => "#FEF8F8";
    public string SurfaceVariant => "#E9E0E2";
    public string OnSurface => "#363133";
    public string OnSurfaceVariant => "#635D5F";
    public string SurfaceDim => "#E1D8DA";
    public string SurfaceBright => "#FEF8F8";
    public string SurfaceTint => "#685B60";
    // Background
    public string Background => "#FEF8F8";
    public string OnBackground => "#363133";
    // Outline
    public string Outline => "#80797B";
    public string OutlineVariant => "#B8B0B2";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0F0E0E";
    public string InverseOnSurface => "#A09C9C";
    public string InversePrimary => "#F6E3EA";
    // Primary Fixed
    public string PrimaryFixed => "#F1DEE4";
    public string OnPrimaryFixed => "#483C41";
    public string PrimaryFixedDim => "#E2D0D6";
    public string OnPrimaryFixedVariant => "#65585D";
    // Secondary Fixed
    public string SecondaryFixed => "#EBE0E2";
    public string OnSecondaryFixed => "#443E40";
    public string SecondaryFixedDim => "#DCD2D4";
    public string OnSecondaryFixedVariant => "#615A5C";
    // Tertiary Fixed
    public string TertiaryFixed => "#F6DDFD";
    public string OnTertiaryFixed => "#4C3B53";
    public string TertiaryFixedDim => "#E7CFEE";
    public string OnTertiaryFixedVariant => "#695771";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F9F2F2";
    public string SurfaceContainer => "#F4ECED";
    public string SurfaceContainerHigh => "#EFE6E7";
    public string SurfaceContainerHighest => "#E9E0E2";
}
