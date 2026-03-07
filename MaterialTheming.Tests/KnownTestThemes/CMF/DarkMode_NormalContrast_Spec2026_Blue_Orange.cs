namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_NormalContrast_Spec2026_Blue_Orange : ITestThemeSecondSourceColor
{
    public string SourceColor => "#185FAA"; //Blue
    public string SecondSourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#67A0EF";
    public string OnPrimary => "#002043";
    public string PrimaryContainer => "#185FAA";
    public string OnPrimaryContainer => "#F6F7FF";
    // Secondary
    public string Secondary => "#8B9FC0";
    public string OnSecondary => "#0A203C";
    public string SecondaryContainer => "#1D314D";
    public string OnSecondaryContainer => "#9DB1D4";
    // Tertiary
    public string Tertiary => "#EA8745";
    public string OnTertiary => "#3D1800";
    public string TertiaryContainer => "#DA7A39";
    public string OnTertiaryContainer => "#250C00";
    // Error
    public string Error => "#FB877D";
    public string OnError => "#570B0B";
    public string ErrorContainer => "#4B0205";
    public string OnErrorContainer => "#F07F75";
    // Surface
    public string Surface => "#090E17";
    public string SurfaceVariant => "#1B2637";
    public string OnSurface => "#DBE6FD";
    public string OnSurfaceVariant => "#A0ACC1";
    public string SurfaceDim => "#090E17";
    public string SurfaceBright => "#212D3E";
    public string SurfaceTint => "#67A0EF";
    // Background
    public string Background => "#090E17";
    public string OnBackground => "#DBE6FD";
    // Outline
    public string Outline => "#6B768A";
    public string OutlineVariant => "#3D485B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F9F9FF";
    public string InverseOnSurface => "#50555F";
    public string InversePrimary => "#1960AB";
    // Primary Fixed
    public string PrimaryFixed => "#185FAA";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#00539B";
    public string OnPrimaryFixedVariant => "#C5DAFF";
    // Secondary Fixed
    public string SecondaryFixed => "#C1D5F9";
    public string OnSecondaryFixed => "#233753";
    public string SecondaryFixedDim => "#B3C7EB";
    public string OnSecondaryFixedVariant => "#405371";
    // Tertiary Fixed
    public string TertiaryFixed => "#DA7A39";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#CA6E2E";
    public string OnTertiaryFixedVariant => "#371500";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#0C141F";
    public string SurfaceContainer => "#111A27";
    public string SurfaceContainerHigh => "#17202E";
    public string SurfaceContainerHighest => "#1B2637";
}
