namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class LightMode_NormalContrast_Spec2026_Orange_Blue : ITestThemeSecondSourceColor
{
    public string SourceColor => "#D77837"; //Orange
    public string SecondSourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#994805";
    public string OnPrimary => "#FFF7F5";
    public string PrimaryContainer => "#E78543";
    public string OnPrimaryContainer => "#391600";
    // Secondary
    public string Secondary => "#815539";
    public string OnSecondary => "#FFF7F5";
    public string SecondaryContainer => "#FABF9D";
    public string OnSecondaryContainer => "#623A21";
    // Tertiary
    public string Tertiary => "#185FAA";
    public string OnTertiary => "#F6F7FF";
    public string TertiaryContainer => "#2B6CB7";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#9F403C";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#F8847C";
    public string OnErrorContainer => "#54080A";
    // Surface
    public string Surface => "#FFF8F5";
    public string SurfaceVariant => "#FFDBC8";
    public string OnSurface => "#462C1D";
    public string OnSurfaceVariant => "#785846";
    public string SurfaceDim => "#FCD1BA";
    public string SurfaceBright => "#FFF8F5";
    public string SurfaceTint => "#994805";
    // Background
    public string Background => "#FFF8F5";
    public string OnBackground => "#462C1D";
    // Outline
    public string Outline => "#967360";
    public string OutlineVariant => "#D1AA94";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#1C0901";
    public string InverseOnSurface => "#AF988C";
    public string InversePrimary => "#FE9753";
    // Primary Fixed
    public string PrimaryFixed => "#E78543";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#D77837";
    public string OnPrimaryFixedVariant => "#481E00";
    // Secondary Fixed
    public string SecondaryFixed => "#FABF9D";
    public string OnSecondaryFixed => "#4B270F";
    public string SecondaryFixedDim => "#EBB290";
    public string OnSecondaryFixedVariant => "#6C4329";
    // Tertiary Fixed
    public string TertiaryFixed => "#2B6CB7";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#185FAA";
    public string OnTertiaryFixedVariant => "#C5DAFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1EA";
    public string SurfaceContainer => "#FFEADF";
    public string SurfaceContainerHigh => "#FFE3D4";
    public string SurfaceContainerHighest => "#FFDBC8";
}
