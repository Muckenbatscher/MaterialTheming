namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#002C58";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#00498B";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#232B48";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#404867";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#2A2654";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#474373";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F9F9FF";
    public string SurfaceVariant => "#DCE2F2";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#B4B9C4";
    public string SurfaceBright => "#F9F9FF";
    public string SurfaceTint => "#005FB0";
    // Background
    public string Background => "#F9F9FF";
    public string OnBackground => "#171C24";
    // Outline
    public string Outline => "#262C38";
    public string OutlineVariant => "#434956";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2B313A";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#A6C8FF";
    // Primary Fixed
    public string PrimaryFixed => "#00498B";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#003363";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#404867";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#29314F";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#474373";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#312D5B";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#ECF1FD";
    public string SurfaceContainer => "#DEE2EF";
    public string SurfaceContainerHigh => "#D0D4E0";
    public string SurfaceContainerHighest => "#C2C6D2";
}
