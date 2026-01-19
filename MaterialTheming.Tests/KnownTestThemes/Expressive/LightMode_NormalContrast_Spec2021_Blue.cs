namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#3E692E";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#BFF0A6";
    public string OnPrimaryContainer => "#275018";
    // Secondary
    public string Secondary => "#7B5266";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FFD8E8";
    public string OnSecondaryContainer => "#613B4E";
    // Tertiary
    public string Tertiary => "#505C8B";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#DCE1FF";
    public string OnTertiaryContainer => "#384472";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FAF8FF";
    public string SurfaceVariant => "#E0E1F3";
    public string OnSurface => "#1A1B23";
    public string OnSurfaceVariant => "#444654";
    public string SurfaceDim => "#DAD9E4";
    public string SurfaceBright => "#FAF8FF";
    public string SurfaceTint => "#3E692E";
    // Background
    public string Background => "#FAF8FF";
    public string OnBackground => "#1A1B23";
    // Outline
    public string Outline => "#747685";
    public string OutlineVariant => "#C4C5D6";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2F3038";
    public string InverseOnSurface => "#F1F0FA";
    public string InversePrimary => "#A3D48D";
    // Primary Fixed
    public string PrimaryFixed => "#BFF0A6";
    public string OnPrimaryFixed => "#042100";
    public string PrimaryFixedDim => "#A3D48D";
    public string OnPrimaryFixedVariant => "#275018";
    // Secondary Fixed
    public string SecondaryFixed => "#FFD8E8";
    public string OnSecondaryFixed => "#2F1122";
    public string SecondaryFixedDim => "#EBB8CF";
    public string OnSecondaryFixedVariant => "#613B4E";
    // Tertiary Fixed
    public string TertiaryFixed => "#DCE1FF";
    public string OnTertiaryFixed => "#0A1844";
    public string TertiaryFixedDim => "#B8C4FA";
    public string OnTertiaryFixedVariant => "#384472";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F3F2FD";
    public string SurfaceContainer => "#EEEDF8";
    public string SurfaceContainerHigh => "#E8E7F2";
    public string SurfaceContainerHighest => "#E2E1EC";
}
