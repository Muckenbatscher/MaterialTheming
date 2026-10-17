namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_NormalContrast_Spec2026_Watch_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#B4D0FF";
    public string OnPrimary => "#002143";
    public string PrimaryContainer => "#004787";
    public string OnPrimaryContainer => "#D1E1FF";
    // Secondary
    public string Secondary => "#C7DBFF";
    public string OnSecondary => "#273B57";
    public string SecondaryContainer => "#344765";
    public string OnSecondaryContainer => "#D1E1FF";
    // Tertiary
    public string Tertiary => "#D0C8FF";
    public string OnTertiary => "#1E076A";
    public string TertiaryContainer => "#9E92F0";
    public string OnTertiaryContainer => "#0E0046";
    // Error
    public string Error => "#FFBEB9";
    public string OnError => "#3F0004";
    public string ErrorContainer => "#7F2927";
    public string OnErrorContainer => "#FFD7D4";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#1B2637";
    public string OnSurface => "#DEE8FF";
    public string OnSurfaceVariant => "#C4CEE4";
    public string SurfaceDim => "#040E1E";
    public string SurfaceBright => "#222D3D";
    public string SurfaceTint => "#B4D0FF";
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
    public string InverseOnSurface => "#4B5668";
    public string InversePrimary => "#0055A0";
    // Primary Fixed
    public string PrimaryFixed => "#B4D0FF";
    public string OnPrimaryFixed => "#002143";
    public string PrimaryFixedDim => "#75ADFD";
    public string OnPrimaryFixedVariant => "#00407A";
    // Secondary Fixed
    public string SecondaryFixed => "#C7DBFF";
    public string OnSecondaryFixed => "#273B57";
    public string SecondaryFixedDim => "#B9CDF1";
    public string OnSecondaryFixedVariant => "#344765";
    // Tertiary Fixed
    public string TertiaryFixed => "#D0C8FF";
    public string OnTertiaryFixed => "#1E076A";
    public string TertiaryFixedDim => "#AB9FFF";
    public string OnTertiaryFixedVariant => "#3E318A";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1B2637";
    public string SurfaceContainer => "#263142";
    public string SurfaceContainerHigh => "#313C4D";
    public string SurfaceContainerHighest => "#1B2637";
}
