namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_NormalContrast_Spec2026_Blue_Red : ITestThemeSecondSourceColor
{
    public string SourceColor => "#185FAA"; //Blue
    public string SecondSourceColor => "#D2463D"; //Red
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
    public string Tertiary => "#FF7165";
    public string OnTertiary => "#4A0003";
    public string TertiaryContainer => "#CF443B";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#FB877F";
    public string OnError => "#570B0D";
    public string ErrorContainer => "#480005";
    public string OnErrorContainer => "#EE7D75";
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
    public string PrimaryFixed => "#2B6CB7";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#185FAA";
    public string OnPrimaryFixedVariant => "#C5DAFF";
    // Secondary Fixed
    public string SecondaryFixed => "#C1D5F9";
    public string OnSecondaryFixed => "#233753";
    public string SecondaryFixedDim => "#B3C7EB";
    public string OnSecondaryFixedVariant => "#405371";
    // Tertiary Fixed
    public string TertiaryFixed => "#CF443B";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#BD3730";
    public string OnTertiaryFixedVariant => "#FFE2DE";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#0C141F";
    public string SurfaceContainer => "#111A27";
    public string SurfaceContainerHigh => "#17202E";
    public string SurfaceContainerHighest => "#1B2637";
}
