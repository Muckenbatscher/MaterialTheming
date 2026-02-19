namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class LightMode_NormalContrast_Spec2026_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#7A42B2";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#945CCD";
    public string OnPrimaryContainer => "#0B001B";
    // Secondary
    public string Secondary => "#6C5582";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#E6CAFE";
    public string OnSecondaryContainer => "#69527E";
    // Tertiary
    public string Tertiary => "#6F5D00";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#C4AA3D";
    public string OnTertiaryContainer => "#4C3F00";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FFF7FE";
    public string SurfaceVariant => "#EBDEF0";
    public string OnSurface => "#1E1A21";
    public string OnSurfaceVariant => "#4C4451";
    public string SurfaceDim => "#E0D7E1";
    public string SurfaceBright => "#FFF7FE";
    public string SurfaceTint => "#7A42B2";
    // Background
    public string Background => "#FFF7FE";
    public string OnBackground => "#1E1A21";
    // Outline
    public string Outline => "#7D7483";
    public string OutlineVariant => "#CEC3D3";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#332F36";
    public string InverseOnSurface => "#F7EEF8";
    public string InversePrimary => "#DCB8FF";
    // Primary Fixed
    public string PrimaryFixed => "#F0DBFF";
    public string OnPrimaryFixed => "#2C0051";
    public string PrimaryFixedDim => "#DCB8FF";
    public string OnPrimaryFixedVariant => "#612798";
    // Secondary Fixed
    public string SecondaryFixed => "#F0DBFF";
    public string OnSecondaryFixed => "#26113A";
    public string SecondaryFixedDim => "#D7BCEF";
    public string OnSecondaryFixedVariant => "#533E68";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFE16E";
    public string OnTertiaryFixed => "#221B00";
    public string TertiaryFixedDim => "#E1C555";
    public string OnTertiaryFixedVariant => "#544600";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FAF1FB";
    public string SurfaceContainer => "#F4EBF5";
    public string SurfaceContainerHigh => "#EEE5F0";
    public string SurfaceContainerHighest => "#E9E0EA";
}
