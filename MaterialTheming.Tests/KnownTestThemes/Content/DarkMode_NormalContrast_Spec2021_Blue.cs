namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_NormalContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#A6C8FF";
    public string OnPrimary => "#00315F";
    public string PrimaryContainer => "#185FAA";
    public string OnPrimaryContainer => "#C5DAFF";
    // Secondary
    public string Secondary => "#B3C7EB";
    public string OnSecondary => "#1D314D";
    public string SecondaryContainer => "#344765";
    public string OnSecondaryContainer => "#A2B6D9";
    // Tertiary
    public string Tertiary => "#EEB0FF";
    public string OnTertiary => "#4E1363";
    public string TertiaryContainer => "#814695";
    public string OnTertiaryContainer => "#F6CAFF";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#111318";
    public string SurfaceVariant => "#424751";
    public string OnSurface => "#E1E2E9";
    public string OnSurfaceVariant => "#C2C6D3";
    public string SurfaceDim => "#111318";
    public string SurfaceBright => "#37393F";
    public string SurfaceTint => "#A6C8FF";
    // Background
    public string Background => "#111318";
    public string OnBackground => "#E1E2E9";
    // Outline
    public string Outline => "#8C919C";
    public string OutlineVariant => "#424751";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E1E2E9";
    public string InverseOnSurface => "#2E3036";
    public string InversePrimary => "#185FAA";
    // Primary Fixed
    public string PrimaryFixed => "#D5E3FF";
    public string OnPrimaryFixed => "#001C3B";
    public string PrimaryFixedDim => "#A6C8FF";
    public string OnPrimaryFixedVariant => "#004787";
    // Secondary Fixed
    public string SecondaryFixed => "#D5E3FF";
    public string OnSecondaryFixed => "#051C37";
    public string SecondaryFixedDim => "#B3C7EB";
    public string OnSecondaryFixedVariant => "#344765";
    // Tertiary Fixed
    public string TertiaryFixed => "#FAD7FF";
    public string OnTertiaryFixed => "#330045";
    public string TertiaryFixedDim => "#EEB0FF";
    public string OnTertiaryFixedVariant => "#672D7B";
    // Surface Container
    public string SurfaceContainerLowest => "#0C0E13";
    public string SurfaceContainerLow => "#191C21";
    public string SurfaceContainer => "#1D2025";
    public string SurfaceContainerHigh => "#272A2F";
    public string SurfaceContainerHighest => "#32353A";
}
