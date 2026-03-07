namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_HighContrast_Spec2026_Blue_Blue : ITestThemeSecondSourceColor
{
    public string SourceColor => "#185FAA"; //Blue
    public string SecondSourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#D9E6FF";
    public string OnPrimary => "#002C58";
    public string PrimaryContainer => "#6DA5F5";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#D9E6FF";
    public string OnSecondary => "#182D48";
    public string SecondaryContainer => "#91A5C7";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#D9E6FF";
    public string OnTertiary => "#002C58";
    public string TertiaryContainer => "#81A5DD";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFDEDA";
    public string OnError => "#5A0D0D";
    public string ErrorContainer => "#F58379";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#090E17";
    public string SurfaceVariant => "#1B2637";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DBE6FD";
    public string SurfaceDim => "#090E17";
    public string SurfaceBright => "#212D3E";
    public string SurfaceTint => "#D9E6FF";
    // Background
    public string Background => "#090E17";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#AEB9CF";
    public string OutlineVariant => "#99A4BA";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F9F9FF";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#00386D";
    // Primary Fixed
    public string PrimaryFixed => "#6DA5F5";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#6DA5F5";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#C1D5F9";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#B3C7EB";
    public string OnSecondaryFixedVariant => "#001128";
    // Tertiary Fixed
    public string TertiaryFixed => "#81A5DD";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#81A5DD";
    public string OnTertiaryFixedVariant => "#000000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#0C141F";
    public string SurfaceContainer => "#111A27";
    public string SurfaceContainerHigh => "#17202E";
    public string SurfaceContainerHighest => "#1B2637";
}
