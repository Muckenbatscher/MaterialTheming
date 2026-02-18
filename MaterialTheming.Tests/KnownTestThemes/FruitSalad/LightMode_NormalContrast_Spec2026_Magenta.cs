namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_NormalContrast_Spec2026_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#684FA4";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#E9DDFF";
    public string OnPrimaryContainer => "#50378A";
    // Secondary
    public string Secondary => "#66558E";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#E9DDFF";
    public string OnSecondaryContainer => "#4D3D75";
    // Tertiary
    public string Tertiary => "#884B6B";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FFD8E8";
    public string OnTertiaryContainer => "#6C3353";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FFF8F8";
    public string SurfaceVariant => "#FDD9E8";
    public string OnSurface => "#24181E";
    public string OnSurfaceVariant => "#58404B";
    public string SurfaceDim => "#EBD4DC";
    public string SurfaceBright => "#FFF8F8";
    public string SurfaceTint => "#684FA4";
    // Background
    public string Background => "#FFF8F8";
    public string OnBackground => "#24181E";
    // Outline
    public string Outline => "#8C6F7C";
    public string OutlineVariant => "#E0BDCC";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#3B2C33";
    public string InverseOnSurface => "#FFECF2";
    public string InversePrimary => "#D0BCFF";
    // Primary Fixed
    public string PrimaryFixed => "#E9DDFF";
    public string OnPrimaryFixed => "#23005C";
    public string PrimaryFixedDim => "#D0BCFF";
    public string OnPrimaryFixedVariant => "#50378A";
    // Secondary Fixed
    public string SecondaryFixed => "#E9DDFF";
    public string OnSecondaryFixed => "#210F47";
    public string SecondaryFixedDim => "#D0BCFE";
    public string OnSecondaryFixedVariant => "#4D3D75";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFD8E8";
    public string OnTertiaryFixed => "#380726";
    public string TertiaryFixedDim => "#FCB0D5";
    public string OnTertiaryFixedVariant => "#6C3353";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#FFE8F0";
    public string SurfaceContainerHigh => "#FAE2EB";
    public string SurfaceContainerHighest => "#F4DDE5";
}
