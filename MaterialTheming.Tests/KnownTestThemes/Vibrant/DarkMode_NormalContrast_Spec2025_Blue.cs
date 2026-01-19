namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#78B0FF";
    public string OnPrimary => "#002F5C";
    public string PrimaryContainer => "#5BA2FF";
    public string OnPrimaryContainer => "#002347";
    // Secondary
    public string Secondary => "#719BFF";
    public string OnSecondary => "#001D50";
    public string SecondaryContainer => "#0845A6";
    public string OnSecondaryContainer => "#CAD7FF";
    // Tertiary
    public string Tertiary => "#EAA5FF";
    public string OnTertiary => "#5D1877";
    public string TertiaryContainer => "#E094F8";
    public string OnTertiaryContainer => "#52076C";
    // Error
    public string Error => "#FF716C";
    public string OnError => "#490006";
    public string ErrorContainer => "#9F0519";
    public string OnErrorContainer => "#FFA8A3";
    // Surface
    public string Surface => "#000C2B";
    public string SurfaceVariant => "#082355";
    public string OnSurface => "#DEE5FF";
    public string OnSurfaceVariant => "#9CAAD5";
    public string SurfaceDim => "#000C2B";
    public string SurfaceBright => "#0D295F";
    public string SurfaceTint => "#78B0FF";
    // Background
    public string Background => "#000C2B";
    public string OnBackground => "#DEE5FF";
    // Outline
    public string Outline => "#66759C";
    public string OutlineVariant => "#39476C";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FAF8FF";
    public string InverseOnSurface => "#46547A";
    public string InversePrimary => "#005FB1";
    // Primary Fixed
    public string PrimaryFixed => "#5BA2FF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#3594FF";
    public string OnPrimaryFixedVariant => "#002C58";
    // Secondary Fixed
    public string SecondaryFixed => "#C2D1FF";
    public string OnSecondaryFixed => "#002F79";
    public string SecondaryFixedDim => "#ADC3FF";
    public string OnSecondaryFixedVariant => "#144BAB";
    // Tertiary Fixed
    public string TertiaryFixed => "#E094F8";
    public string OnTertiaryFixed => "#2D003E";
    public string TertiaryFixedDim => "#D187E9";
    public string OnTertiaryFixedVariant => "#5C1675";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#001136";
    public string SurfaceContainer => "#011742";
    public string SurfaceContainerHigh => "#041D4B";
    public string SurfaceContainerHighest => "#082355";
}
