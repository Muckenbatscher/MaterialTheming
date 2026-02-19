namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2026_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#D9E6FF";
    public string OnPrimary => "#002C58";
    public string PrimaryContainer => "#63A5FF";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#DEE5FF";
    public string OnSecondary => "#002868";
    public string SecondaryContainer => "#7BA1FF";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FBDCFF";
    public string OnTertiary => "#4C0066";
    public string TertiaryContainer => "#E094F8";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFDEDB";
    public string OnError => "#60000A";
    public string ErrorContainer => "#FF7C76";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000C2B";
    public string SurfaceVariant => "#082355";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DEE5FF";
    public string SurfaceDim => "#000C2B";
    public string SurfaceBright => "#0D295F";
    public string SurfaceTint => "#D9E6FF";
    // Background
    public string Background => "#000C2B";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#A9B8E3";
    public string OutlineVariant => "#94A3CD";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FAF8FF";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#00386D";
    // Primary Fixed
    public string PrimaryFixed => "#63A5FF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#4098FF";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#C2D1FF";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#ADC3FF";
    public string OnSecondaryFixedVariant => "#000B29";
    // Tertiary Fixed
    public string TertiaryFixed => "#E094F8";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#D187E9";
    public string OnTertiaryFixedVariant => "#000000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#001136";
    public string SurfaceContainer => "#011742";
    public string SurfaceContainerHigh => "#041D4B";
    public string SurfaceContainerHighest => "#082355";
}
