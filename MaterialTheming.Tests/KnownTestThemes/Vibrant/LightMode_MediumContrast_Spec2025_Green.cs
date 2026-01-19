namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#004A1B";
    public string OnPrimary => "#56F07B";
    public string PrimaryContainer => "#008737";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#00492B";
    public string OnSecondary => "#6DECA7";
    public string SecondaryContainer => "#008652";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#004650";
    public string OnTertiary => "#51E6FF";
    public string TertiaryContainer => "#008091";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#7D1800";
    public string OnError => "#FFC7BA";
    public string ErrorContainer => "#D53D18";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#DCFFE5";
    public string SurfaceVariant => "#A8ECC0";
    public string OnSurface => "#002513";
    public string OnSurfaceVariant => "#1B472F";
    public string SurfaceDim => "#9CE4B6";
    public string SurfaceBright => "#DCFFE5";
    public string SurfaceTint => "#004A1B";
    // Background
    public string Background => "#DCFFE5";
    public string OnBackground => "#002513";
    // Outline
    public string Outline => "#38644A";
    public string OutlineVariant => "#548064";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#001207";
    public string InverseOnSurface => "#A0D0AF";
    public string InversePrimary => "#63FC85";
    // Primary Fixed
    public string PrimaryFixed => "#008737";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#007930";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#008652";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#007849";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#008091";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#007382";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#C7FDD8";
    public string SurfaceContainer => "#BBF6CE";
    public string SurfaceContainerHigh => "#B2F1C7";
    public string SurfaceContainerHighest => "#A8ECC0";
}
