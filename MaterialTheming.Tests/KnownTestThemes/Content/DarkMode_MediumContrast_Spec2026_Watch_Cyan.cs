namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_MediumContrast_Spec2026_Watch_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FEFFFF";
    public string OnPrimary => "#00181C";
    public string PrimaryContainer => "#0093A4";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FEFFFF";
    public string OnSecondary => "#002429";
    public string SecondaryContainer => "#5F8D95";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#51B1EF";
    public string OnTertiaryContainer => "#002033";
    // Error
    public string Error => "#FFBEB9";
    public string OnError => "#3D0004";
    public string ErrorContainer => "#D06661";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#0F292E";
    public string OnSurface => "#FEFFFF";
    public string OnSurfaceVariant => "#B8D3D8";
    public string SurfaceDim => "#001114";
    public string SurfaceBright => "#163034";
    public string SurfaceTint => "#FEFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#90AAB0";
    public string OutlineVariant => "#708A8F";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EDFCFF";
    public string InverseOnSurface => "#233C40";
    public string InversePrimary => "#003F47";
    // Primary Fixed
    public string PrimaryFixed => "#5DE9FF";
    public string OnPrimaryFixed => "#00181C";
    public string PrimaryFixedDim => "#49DBF1";
    public string OnPrimaryFixedVariant => "#003E46";
    // Secondary Fixed
    public string SecondaryFixed => "#BBEBF4";
    public string OnSecondaryFixed => "#002429";
    public string SecondaryFixedDim => "#ADDCE6";
    public string OnSecondaryFixedVariant => "#13464D";
    // Tertiary Fixed
    public string TertiaryFixed => "#A0D5FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#60BEFE";
    public string OnTertiaryFixedVariant => "#002D45";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#0F292E";
    public string SurfaceContainer => "#1B3439";
    public string SurfaceContainerHigh => "#263F44";
    public string SurfaceContainerHighest => "#0F292E";
}
