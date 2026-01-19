namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#0A3400";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#29531A";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#432133";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#633E51";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#1D2955";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#3B4774";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FAF8FF";
    public string SurfaceVariant => "#E0E1F3";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#B8B8C2";
    public string SurfaceBright => "#FAF8FF";
    public string SurfaceTint => "#3E692E";
    // Background
    public string Background => "#FAF8FF";
    public string OnBackground => "#1A1B23";
    // Outline
    public string Outline => "#292C38";
    public string OutlineVariant => "#464856";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2F3038";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#A3D48D";
    // Primary Fixed
    public string PrimaryFixed => "#29531A";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#123B05";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#633E51";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#4A283A";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#3B4774";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#24305C";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F1F0FA";
    public string SurfaceContainer => "#E2E1EC";
    public string SurfaceContainerHigh => "#D4D3DE";
    public string SurfaceContainerHighest => "#C6C5D0";
}
