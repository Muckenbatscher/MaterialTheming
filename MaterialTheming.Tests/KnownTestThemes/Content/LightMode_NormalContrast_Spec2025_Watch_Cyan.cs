namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_NormalContrast_Spec2025_Watch_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#5DE9FF";
    public string OnPrimary => "#003E46";
    public string PrimaryContainer => "#004F58";
    public string OnPrimaryContainer => "#90EEFF";
    // Secondary
    public string Secondary => "#BBEBF4";
    public string OnSecondary => "#13464D";
    public string SecondaryContainer => "#1C4D55";
    public string OnSecondaryContainer => "#B8E8F1";
    // Tertiary
    public string Tertiary => "#A0D5FF";
    public string OnTertiary => "#002D45";
    public string TertiaryContainer => "#51B1EF";
    public string OnTertiaryContainer => "#002033";
    // Error
    public string Error => "#FFBEB9";
    public string OnError => "#3F0004";
    public string ErrorContainer => "#7F2928";
    public string OnErrorContainer => "#FFD7D4";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#0F292E";
    public string OnSurface => "#D1EDF2";
    public string OnSurfaceVariant => "#B8D3D8";
    public string SurfaceDim => "#001114";
    public string SurfaceBright => "#163034";
    public string SurfaceTint => "#5DE9FF";
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
    public string InverseOnSurface => "#40595E";
    public string InversePrimary => "#005E69";
    // Primary Fixed
    public string PrimaryFixed => "#5DE9FF";
    public string OnPrimaryFixed => "#003E46";
    public string PrimaryFixedDim => "#49DBF1";
    public string OnPrimaryFixedVariant => "#004F58";
    // Secondary Fixed
    public string SecondaryFixed => "#BBEBF4";
    public string OnSecondaryFixed => "#13464D";
    public string SecondaryFixedDim => "#ADDCE6";
    public string OnSecondaryFixedVariant => "#1C4D55";
    // Tertiary Fixed
    public string TertiaryFixed => "#A0D5FF";
    public string OnTertiaryFixed => "#002D45";
    public string TertiaryFixedDim => "#60BEFE";
    public string OnTertiaryFixedVariant => "#004B70";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#0F292E";
    public string SurfaceContainer => "#1B3439";
    public string SurfaceContainerHigh => "#263F44";
    public string SurfaceContainerHighest => "#0F292E";
}
