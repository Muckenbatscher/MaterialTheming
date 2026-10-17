namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_MediumContrast_Spec2026_Watch_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#4C87D4";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFEFF";
    public string OnSecondary => "#011833";
    public string SecondaryContainer => "#7387A7";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#9E92F0";
    public string OnTertiaryContainer => "#0E0046";
    // Error
    public string Error => "#FFBEB9";
    public string OnError => "#3D0004";
    public string ErrorContainer => "#D06561";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#1B2637";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#C4CEE4";
    public string SurfaceDim => "#040E1E";
    public string SurfaceBright => "#222D3D";
    public string SurfaceTint => "#FFFEFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#9BA6BB";
    public string OutlineVariant => "#7B869A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F9F9FF";
    public string InverseOnSurface => "#2E394A";
    public string InversePrimary => "#00386D";
    // Primary Fixed
    public string PrimaryFixed => "#B4D0FF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#75ADFD";
    public string OnPrimaryFixedVariant => "#002143";
    // Secondary Fixed
    public string SecondaryFixed => "#C7DBFF";
    public string OnSecondaryFixed => "#011833";
    public string SecondaryFixedDim => "#B9CDF1";
    public string OnSecondaryFixedVariant => "#273B57";
    // Tertiary Fixed
    public string TertiaryFixed => "#D0C8FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#AB9FFF";
    public string OnTertiaryFixedVariant => "#1E076A";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1B2637";
    public string SurfaceContainer => "#263142";
    public string SurfaceContainerHigh => "#313C4D";
    public string SurfaceContainerHighest => "#1B2637";
}
