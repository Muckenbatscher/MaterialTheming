namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#D4C2C8";
    public string OnPrimary => "#493D42";
    public string PrimaryContainer => "#504348";
    public string OnPrimaryContainer => "#DECCD2";
    // Secondary
    public string Secondary => "#A59C9E";
    public string OnSecondary => "#241F21";
    public string SecondaryContainer => "#403A3C";
    public string OnSecondaryContainer => "#C7BDBF";
    // Tertiary
    public string Tertiary => "#FEEFFF";
    public string OnTertiary => "#68556F";
    public string TertiaryContainer => "#F6DDFD";
    public string OnTertiaryContainer => "#5F4D67";
    // Error
    public string Error => "#EC7C8A";
    public string OnError => "#490013";
    public string ErrorContainer => "#7F2737";
    public string OnErrorContainer => "#FF97A3";
    // Surface
    public string Surface => "#0F0E0E";
    public string SurfaceVariant => "#292526";
    public string OnSurface => "#ECE3E5";
    public string OnSurfaceVariant => "#B1A9AB";
    public string SurfaceDim => "#0F0E0E";
    public string SurfaceBright => "#302B2D";
    public string SurfaceTint => "#D4C2C8";
    // Background
    public string Background => "#0F0E0E";
    public string OnBackground => "#ECE3E5";
    // Outline
    public string Outline => "#7A7475";
    public string OutlineVariant => "#4C4648";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FEF8F8";
    public string InverseOnSurface => "#575455";
    public string InversePrimary => "#695B61";
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
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#151313";
    public string SurfaceContainer => "#1C191A";
    public string SurfaceContainerHigh => "#221F20";
    public string SurfaceContainerHighest => "#292526";
}
