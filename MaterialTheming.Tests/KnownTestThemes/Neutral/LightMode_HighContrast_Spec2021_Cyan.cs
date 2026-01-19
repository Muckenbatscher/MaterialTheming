namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#1F2F32";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#3C4C4F";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#252E2F";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#424B4D";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#173034";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#354D51";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FAF9F9";
    public string SurfaceVariant => "#E3E2E2";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#B9B8B8";
    public string SurfaceBright => "#FAF9F9";
    public string SurfaceTint => "#516164";
    // Background
    public string Background => "#FAF9F9";
    public string OnBackground => "#1B1C1C";
    // Outline
    public string Outline => "#2B2C2C";
    public string OutlineVariant => "#484949";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2F3031";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#B8CACD";
    // Primary Fixed
    public string PrimaryFixed => "#3C4C4F";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#253538";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#424B4D";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#2B3436";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#354D51";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#1E363B";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F2F0F0";
    public string SurfaceContainer => "#E3E2E2";
    public string SurfaceContainerHigh => "#D5D4D4";
    public string SurfaceContainerHighest => "#C7C6C6";
}
