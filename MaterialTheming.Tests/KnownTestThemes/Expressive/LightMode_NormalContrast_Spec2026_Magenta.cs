namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2026_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#954271";
    public string OnPrimary => "#FFF7F8";
    public string PrimaryContainer => "#FFA6D3";
    public string OnPrimaryContainer => "#6A1E4C";
    // Secondary
    public string Secondary => "#396763";
    public string OnSecondary => "#E1FFFB";
    public string SecondaryContainer => "#CAFAF4";
    public string OnSecondaryContainer => "#34625E";
    // Tertiary
    public string Tertiary => "#006B60";
    public string OnTertiary => "#E2FFF8";
    public string TertiaryContainer => "#6EF2DF";
    public string OnTertiaryContainer => "#00594F";
    // Error
    public string Error => "#AC3149";
    public string OnError => "#FFF7F7";
    public string ErrorContainer => "#F76A80";
    public string OnErrorContainer => "#68001F";
    // Surface
    public string Surface => "#FFF8F8";
    public string SurfaceVariant => "#FFD8E8";
    public string OnSurface => "#4E243B";
    public string OnSurfaceVariant => "#815069";
    public string SurfaceDim => "#FFCCE3";
    public string SurfaceBright => "#FFF8F8";
    public string SurfaceTint => "#954271";
    // Background
    public string Background => "#FFF8F8";
    public string OnBackground => "#4E243B";
    // Outline
    public string Outline => "#A06B85";
    public string OutlineVariant => "#DCA1BD";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#1C0712";
    public string InverseOnSurface => "#B793A3";
    public string InversePrimary => "#FD99CD";
    // Primary Fixed
    public string PrimaryFixed => "#FFA6D3";
    public string OnPrimaryFixed => "#500537";
    public string PrimaryFixedDim => "#F794C7";
    public string OnPrimaryFixedVariant => "#752856";
    // Secondary Fixed
    public string SecondaryFixed => "#CAFAF4";
    public string OnSecondaryFixed => "#204F4B";
    public string SecondaryFixedDim => "#BCECE6";
    public string OnSecondaryFixedVariant => "#3F6C68";
    // Tertiary Fixed
    public string TertiaryFixed => "#6EF2DF";
    public string OnTertiaryFixed => "#00443D";
    public string TertiaryFixedDim => "#5EE3D1";
    public string OnTertiaryFixedVariant => "#006359";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#FFE8F0";
    public string SurfaceContainerHigh => "#FFE0EC";
    public string SurfaceContainerHighest => "#FFD8E8";
}
