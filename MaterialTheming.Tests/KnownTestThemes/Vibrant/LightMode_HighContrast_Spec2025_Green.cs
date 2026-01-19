namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#00260A";
    public string OnPrimary => "#57F17B";
    public string PrimaryContainer => "#005C23";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#002513";
    public string OnSecondary => "#6EECA7";
    public string SecondaryContainer => "#005B36";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#002429";
    public string OnTertiary => "#54E7FF";
    public string TertiaryContainer => "#005763";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#440800";
    public string OnError => "#FFC8BB";
    public string ErrorContainer => "#991F00";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#DCFFE5";
    public string SurfaceVariant => "#A8ECC0";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#002513";
    public string SurfaceDim => "#9CE4B6";
    public string SurfaceBright => "#DCFFE5";
    public string SurfaceTint => "#00260A";
    // Background
    public string Background => "#DCFFE5";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#1B472F";
    public string OutlineVariant => "#2B573E";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#001207";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#63FC85";
    // Primary Fixed
    public string PrimaryFixed => "#005C23";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#004E1D";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#005B36";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#004E2E";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#005763";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#004A55";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#C7FDD8";
    public string SurfaceContainer => "#BBF6CE";
    public string SurfaceContainerHigh => "#B2F1C7";
    public string SurfaceContainerHighest => "#A8ECC0";
}
