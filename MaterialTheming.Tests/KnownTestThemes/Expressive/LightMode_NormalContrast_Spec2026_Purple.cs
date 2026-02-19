namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2026_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#754C9E";
    public string OnPrimary => "#FFF6FF";
    public string PrimaryContainer => "#D9B1FF";
    public string OnPrimaryContainer => "#502878";
    // Secondary
    public string Secondary => "#4B6647";
    public string OnSecondary => "#EAFFE2";
    public string SecondaryContainer => "#D5F4CC";
    public string OnSecondaryContainer => "#435D3F";
    // Tertiary
    public string Tertiary => "#356B23";
    public string OnTertiary => "#ECFFDE";
    public string TertiaryContainer => "#BFFFA4";
    public string OnTertiaryContainer => "#2E641D";
    // Error
    public string Error => "#AC3149";
    public string OnError => "#FFF7F7";
    public string ErrorContainer => "#F76A80";
    public string OnErrorContainer => "#68001F";
    // Surface
    public string Surface => "#FFF7FE";
    public string SurfaceVariant => "#F0DBFF";
    public string OnSurface => "#3D2A51";
    public string OnSurfaceVariant => "#6C5681";
    public string SurfaceDim => "#EAD0FF";
    public string SurfaceBright => "#FFF7FE";
    public string SurfaceTint => "#754C9E";
    // Background
    public string Background => "#FFF7FE";
    public string OnBackground => "#3D2A51";
    // Outline
    public string Outline => "#88729E";
    public string OutlineVariant => "#C1A8D8";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#130A1E";
    public string InverseOnSurface => "#A797B2";
    public string InversePrimary => "#CDA0F9";
    // Primary Fixed
    public string PrimaryFixed => "#D9B1FF";
    public string OnPrimaryFixed => "#3A0E62";
    public string PrimaryFixedDim => "#CDA0F9";
    public string OnPrimaryFixedVariant => "#593282";
    // Secondary Fixed
    public string SecondaryFixed => "#D5F4CC";
    public string OnSecondaryFixed => "#314B2E";
    public string SecondaryFixedDim => "#C7E5BE";
    public string OnSecondaryFixedVariant => "#4D6848";
    // Tertiary Fixed
    public string TertiaryFixed => "#BFFFA4";
    public string OnTertiaryFixed => "#1B510A";
    public string TertiaryFixedDim => "#B2F097";
    public string OnTertiaryFixedVariant => "#386F26";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FBF0FF";
    public string SurfaceContainer => "#F7E9FF";
    public string SurfaceContainerHigh => "#F4E2FF";
    public string SurfaceContainerHighest => "#F0DBFF";
}
