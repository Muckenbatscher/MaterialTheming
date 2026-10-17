namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_HighContrast_Spec2026_Watch_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#00B6CB";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#7FADB6";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#51B1EF";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFBEB9";
    public string OnError => "#000000";
    public string ErrorContainer => "#F7847F";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#0F292E";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FEFFFF";
    public string SurfaceDim => "#001114";
    public string SurfaceBright => "#163034";
    public string SurfaceTint => "#FFFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#B8D3D8";
    public string OutlineVariant => "#90AAB0";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EDFCFF";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#000000";
    // Primary Fixed
    public string PrimaryFixed => "#5DE9FF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#49DBF1";
    public string OnPrimaryFixedVariant => "#00181C";
    // Secondary Fixed
    public string SecondaryFixed => "#BBEBF4";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#ADDCE6";
    public string OnSecondaryFixedVariant => "#002429";
    // Tertiary Fixed
    public string TertiaryFixed => "#A0D5FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#60BEFE";
    public string OnTertiaryFixedVariant => "#000000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#0F292E";
    public string SurfaceContainer => "#1B3439";
    public string SurfaceContainerHigh => "#263F44";
    public string SurfaceContainerHighest => "#0F292E";
}
