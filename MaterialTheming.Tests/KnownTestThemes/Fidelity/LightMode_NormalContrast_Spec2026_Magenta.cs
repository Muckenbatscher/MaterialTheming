namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class LightMode_NormalContrast_Spec2026_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#A62477";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#C54091";
    public string OnPrimaryContainer => "#FFFBFF";
    // Secondary
    public string Secondary => "#8A496C";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FFAFD6";
    public string OnSecondaryContainer => "#7C3E5F";
    // Tertiary
    public string Tertiary => "#2D6900";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#3A8500";
    public string OnTertiaryContainer => "#F9FFED";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FFF8F8";
    public string SurfaceVariant => "#F8DBE6";
    public string OnSurface => "#23181D";
    public string OnSurfaceVariant => "#55414A";
    public string SurfaceDim => "#E9D5DC";
    public string SurfaceBright => "#FFF8F8";
    public string SurfaceTint => "#A92779";
    // Background
    public string Background => "#FFF8F8";
    public string OnBackground => "#23181D";
    // Outline
    public string Outline => "#88717B";
    public string OutlineVariant => "#DBBFCA";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#392D32";
    public string InverseOnSurface => "#FFECF2";
    public string InversePrimary => "#FFAFD6";
    // Primary Fixed
    public string PrimaryFixed => "#FFD8E8";
    public string OnPrimaryFixed => "#3C0028";
    public string PrimaryFixedDim => "#FFAFD6";
    public string OnPrimaryFixedVariant => "#8A0160";
    // Secondary Fixed
    public string SecondaryFixed => "#FFD8E8";
    public string OnSecondaryFixed => "#390526";
    public string SecondaryFixedDim => "#FFAFD6";
    public string OnSecondaryFixedVariant => "#6E3253";
    // Tertiary Fixed
    public string TertiaryFixed => "#A1F96B";
    public string OnTertiaryFixed => "#092100";
    public string TertiaryFixedDim => "#86DC52";
    public string OnTertiaryFixedVariant => "#215100";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#FDE9F0";
    public string SurfaceContainerHigh => "#F8E3EA";
    public string SurfaceContainerHighest => "#F2DDE4";
}
