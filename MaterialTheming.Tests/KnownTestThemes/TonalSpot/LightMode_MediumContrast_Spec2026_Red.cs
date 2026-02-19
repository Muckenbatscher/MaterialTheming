namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2026_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#6A322D";
    public string OnPrimary => "#FFCEC9";
    public string PrimaryContainer => "#A5625B";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#593B38";
    public string OnSecondary => "#FBD0CA";
    public string SecondaryContainer => "#8F6C68";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#5B3D0E";
    public string OnTertiary => "#FFD29B";
    public string TertiaryContainer => "#936E3B";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#821830";
    public string OnError => "#FFCDD1";
    public string ErrorContainer => "#C44B5F";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F7";
    public string SurfaceVariant => "#F6DDDA";
    public string OnSurface => "#2E211F";
    public string OnSurfaceVariant => "#4F3F3D";
    public string SurfaceDim => "#EDD5D2";
    public string SurfaceBright => "#FFF8F7";
    public string SurfaceTint => "#6A322D";
    // Background
    public string Background => "#FFF8F7";
    public string OnBackground => "#2E211F";
    // Outline
    public string Outline => "#6D5B59";
    public string OutlineVariant => "#8A7674";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#130C0C";
    public string InverseOnSurface => "#D0C1C0";
    public string InversePrimary => "#FDACA3";
    // Primary Fixed
    public string PrimaryFixed => "#A5625B";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#97564F";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#8F6C68";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#82605C";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#936E3B";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#856130";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0EE";
    public string SurfaceContainer => "#FEE9E6";
    public string SurfaceContainerHigh => "#FAE3E0";
    public string SurfaceContainerHighest => "#F6DDDA";
}
