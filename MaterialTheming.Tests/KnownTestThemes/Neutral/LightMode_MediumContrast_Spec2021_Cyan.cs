namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#29393C";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#5F7073";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#2F3839";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#656F71";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#223A3E";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#597176";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FAF9F9";
    public string SurfaceVariant => "#E3E2E2";
    public string OnSurface => "#101112";
    public string OnSurfaceVariant => "#353636";
    public string SurfaceDim => "#C7C6C6";
    public string SurfaceBright => "#FAF9F9";
    public string SurfaceTint => "#516164";
    // Background
    public string Background => "#FAF9F9";
    public string OnBackground => "#1B1C1C";
    // Outline
    public string Outline => "#525253";
    public string OutlineVariant => "#6D6D6D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2F3031";
    public string InverseOnSurface => "#F2F0F0";
    public string InversePrimary => "#B8CACD";
    // Primary Fixed
    public string PrimaryFixed => "#5F7073";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#47585B";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#656F71";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#4D5658";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#597176";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#41595D";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F5F3F3";
    public string SurfaceContainer => "#E9E8E8";
    public string SurfaceContainerHigh => "#DDDCDC";
    public string SurfaceContainerHighest => "#D2D1D1";
}
