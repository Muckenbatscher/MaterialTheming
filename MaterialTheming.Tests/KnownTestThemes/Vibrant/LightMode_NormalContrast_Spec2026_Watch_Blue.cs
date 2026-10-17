namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2026_Watch_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#B4D0FF";
    public string OnPrimary => "#00264C";
    public string PrimaryContainer => "#004787";
    public string OnPrimaryContainer => "#D1E1FF";
    // Secondary
    public string Secondary => "#BDCEFF";
    public string OnSecondary => "#193062";
    public string SecondaryContainer => "#304578";
    public string OnSecondaryContainer => "#D6DFFF";
    // Tertiary
    public string Tertiary => "#F1BCFF";
    public string OnTertiary => "#4F1863";
    public string TertiaryContainer => "#DC9CEE";
    public string OnTertiaryContainer => "#430A57";
    // Error
    public string Error => "#FFBEB9";
    public string OnError => "#3F0004";
    public string ErrorContainer => "#7E2A29";
    public string OnErrorContainer => "#FFD7D4";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#082355";
    public string OnSurface => "#E2E7FF";
    public string OnSurfaceVariant => "#BFCDFA";
    public string SurfaceDim => "#000C2B";
    public string SurfaceBright => "#0D295F";
    public string SurfaceTint => "#B4D0FF";
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
    public string InverseOnSurface => "#46547A";
    public string InversePrimary => "#0F559C";
    // Primary Fixed
    public string PrimaryFixed => "#B4D0FF";
    public string OnPrimaryFixed => "#00264C";
    public string PrimaryFixedDim => "#7EB2FF";
    public string OnPrimaryFixedVariant => "#004481";
    // Secondary Fixed
    public string SecondaryFixed => "#BDCEFF";
    public string OnSecondaryFixed => "#193062";
    public string SecondaryFixedDim => "#ABC0FB";
    public string OnSecondaryFixedVariant => "#304578";
    // Tertiary Fixed
    public string TertiaryFixed => "#F1BCFF";
    public string OnTertiaryFixed => "#4F1863";
    public string TertiaryFixedDim => "#EAAAFD";
    public string OnTertiaryFixedVariant => "#662F79";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#152448";
    public string SurfaceContainer => "#212F53";
    public string SurfaceContainerHigh => "#2C3A5F";
    public string SurfaceContainerHighest => "#082355";
}
