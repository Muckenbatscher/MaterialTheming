namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2026_Watch_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#5187D1";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFEFF";
    public string OnSecondary => "#00071F";
    public string SecondaryContainer => "#7084BC";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#14001E";
    public string TertiaryContainer => "#DC9CEE";
    public string OnTertiaryContainer => "#430A57";
    // Error
    public string Error => "#FFBEB9";
    public string OnError => "#3D0004";
    public string ErrorContainer => "#CE6762";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#082355";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#BFCDFA";
    public string SurfaceDim => "#000C2B";
    public string SurfaceBright => "#0D295F";
    public string SurfaceTint => "#FFFEFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#97A5CF";
    public string OutlineVariant => "#7785AE";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FAF8FF";
    public string InverseOnSurface => "#29375B";
    public string InversePrimary => "#00386D";
    // Primary Fixed
    public string PrimaryFixed => "#B4D0FF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#7EB2FF";
    public string OnPrimaryFixedVariant => "#00264C";
    // Secondary Fixed
    public string SecondaryFixed => "#BDCEFF";
    public string OnSecondaryFixed => "#00071F";
    public string SecondaryFixedDim => "#ABC0FB";
    public string OnSecondaryFixedVariant => "#193062";
    // Tertiary Fixed
    public string TertiaryFixed => "#F1BCFF";
    public string OnTertiaryFixed => "#14001E";
    public string TertiaryFixedDim => "#EAAAFD";
    public string OnTertiaryFixedVariant => "#4F1863";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#152448";
    public string SurfaceContainer => "#212F53";
    public string SurfaceContainerHigh => "#2C3A5F";
    public string SurfaceContainerHighest => "#082355";
}
