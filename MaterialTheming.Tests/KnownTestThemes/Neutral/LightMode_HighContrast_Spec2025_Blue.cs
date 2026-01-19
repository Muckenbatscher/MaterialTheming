namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#1E242F";
    public string OnPrimary => "#D4DAE9";
    public string PrimaryContainer => "#4C525F";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#222429";
    public string OnSecondary => "#D9DAE0";
    public string SecondaryContainer => "#505258";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#21223A";
    public string OnTertiary => "#D8D7F8";
    public string TertiaryContainer => "#4F506B";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#4F0409";
    public string OnError => "#FFCFCB";
    public string ErrorContainer => "#8E3432";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FCF8F9";
    public string SurfaceVariant => "#E4E2E5";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#232426";
    public string SurfaceDim => "#DBD9DD";
    public string SurfaceBright => "#FCF8F9";
    public string SurfaceTint => "#1E242F";
    // Background
    public string Background => "#FCF8F9";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#424345";
    public string OutlineVariant => "#525254";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0E0E0F";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#E2E8F8";
    // Primary Fixed
    public string PrimaryFixed => "#4C525F";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#404753";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#505258";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#44464C";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#4F506B";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#43445E";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F6F3F4";
    public string SurfaceContainer => "#F0EDEF";
    public string SurfaceContainerHigh => "#EAE7EA";
    public string SurfaceContainerHighest => "#E4E2E5";
}
