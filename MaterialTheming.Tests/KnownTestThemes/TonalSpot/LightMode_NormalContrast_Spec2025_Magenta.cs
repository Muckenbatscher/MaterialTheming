namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#844E6A";
    public string OnPrimary => "#FFF7F8";
    public string PrimaryContainer => "#FDB8D9";
    public string OnPrimaryContainer => "#65334E";
    // Secondary
    public string Secondary => "#725864";
    public string OnSecondary => "#FFF7F8";
    public string SecondaryContainer => "#FDD9E8";
    public string OnSecondaryContainer => "#644A56";
    // Tertiary
    public string Tertiary => "#70557C";
    public string OnTertiary => "#FFF7FC";
    public string TertiaryContainer => "#F0CEFD";
    public string OnTertiaryContainer => "#5D4369";
    // Error
    public string Error => "#A8364B";
    public string OnError => "#FFF7F7";
    public string ErrorContainer => "#F97386";
    public string OnErrorContainer => "#6E0523";
    // Surface
    public string Surface => "#FFF8F8";
    public string SurfaceVariant => "#F1DDE4";
    public string OnSurface => "#3B2F34";
    public string OnSurfaceVariant => "#6A5B61";
    public string SurfaceDim => "#E9D5DC";
    public string SurfaceBright => "#FFF8F8";
    public string SurfaceTint => "#844E6A";
    // Background
    public string Background => "#FFF8F8";
    public string OnBackground => "#3B2F34";
    // Outline
    public string Outline => "#86777D";
    public string OutlineVariant => "#BFADB4";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#120D0F";
    public string InverseOnSurface => "#A59A9D";
    public string InversePrimary => "#FDB8D9";
    // Primary Fixed
    public string PrimaryFixed => "#FDB8D9";
    public string OnPrimaryFixed => "#4E203A";
    public string PrimaryFixedDim => "#EEABCB";
    public string OnPrimaryFixedVariant => "#703C57";
    // Secondary Fixed
    public string SecondaryFixed => "#FDD9E8";
    public string OnSecondaryFixed => "#503844";
    public string SecondaryFixedDim => "#EECBDA";
    public string OnSecondaryFixedVariant => "#6F5460";
    // Tertiary Fixed
    public string TertiaryFixed => "#F0CEFD";
    public string OnTertiaryFixed => "#493055";
    public string TertiaryFixedDim => "#E2C1EE";
    public string OnTertiaryFixedVariant => "#674C73";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#FBEAEF";
    public string SurfaceContainerHigh => "#F6E4E9";
    public string SurfaceContainerHighest => "#F1DDE4";
}
