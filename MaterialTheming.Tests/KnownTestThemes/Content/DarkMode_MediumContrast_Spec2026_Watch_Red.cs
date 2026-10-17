namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_MediumContrast_Spec2026_Watch_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#E6544A";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFEFF";
    public string OnSecondary => "#0E0000";
    public string SecondaryContainer => "#BE7168";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#F564B0";
    public string OnTertiaryContainer => "#15000A";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3D000F";
    public string ErrorContainer => "#E5516B";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#3C1D1A";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#F6C2BB";
    public string SurfaceDim => "#1F0605";
    public string SurfaceBright => "#432320";
    public string SurfaceTint => "#FFFEFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#CB9A94";
    public string OutlineVariant => "#A87B75";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F7";
    public string InverseOnSurface => "#512F2B";
    public string InversePrimary => "#770007";
    // Primary Fixed
    public string PrimaryFixed => "#FFBFB8";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FF8074";
    public string OnPrimaryFixedVariant => "#400002";
    // Secondary Fixed
    public string SecondaryFixed => "#FFBFB8";
    public string OnSecondaryFixed => "#0E0000";
    public string SecondaryFixedDim => "#FFA89E";
    public string OnSecondaryFixedVariant => "#561E1A";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFBCD8";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#FF77BC";
    public string OnTertiaryFixedVariant => "#3C0024";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#3C1D1A";
    public string SurfaceContainer => "#482724";
    public string SurfaceContainerHigh => "#55322E";
    public string SurfaceContainerHighest => "#3C1D1A";
}
