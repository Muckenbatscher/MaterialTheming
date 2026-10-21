namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_NormalContrast_Spec2026_Watch_Blue_Red : ITestThemeSecondSourceColor
{
    public string SourceColor => "#185FAA"; //Blue
    public string SecondSourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#5B95E3";
    public string OnPrimary => "#00142D";
    public string PrimaryContainer => "#185FAA";
    public string OnPrimaryContainer => "#F6F7FF";
    // Secondary
    public string Secondary => "#8194B6";
    public string OnSecondary => "#00142D";
    public string SecondaryContainer => "#1D314D";
    public string OnSecondaryContainer => "#9DB1D4";
    // Tertiary
    public string Tertiary => "#F86256";
    public string OnTertiary => "#320001";
    public string TertiaryContainer => "#CF443B";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#FA868D";
    public string OnError => "#580817";
    public string ErrorContainer => "#4C000F";
    public string OnErrorContainer => "#EF7E84";
    // Surface
    public string Surface => "#090E17";
    public string SurfaceVariant => "#1B2637";
    public string OnSurface => "#DBE6FD";
    public string OnSurfaceVariant => "#A0ACC1";
    public string SurfaceDim => "#090E17";
    public string SurfaceBright => "#212D3E";
    public string SurfaceTint => "#5B95E3";
    // Background
    public string Background => "#090E17";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#6B768A";
    public string OutlineVariant => "#3D485B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F9F9FF";
    public string InverseOnSurface => "#50555F";
    public string InversePrimary => "#0055A0";
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
    public string TertiaryFixed => "#CF443B";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#BD3730";
    public string OnTertiaryFixedVariant => "#FFFBFF";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#0C141F";
    public string SurfaceContainer => "#111A27";
    public string SurfaceContainerHigh => "#17202E";
    public string SurfaceContainerHighest => "#1B2637";
}
