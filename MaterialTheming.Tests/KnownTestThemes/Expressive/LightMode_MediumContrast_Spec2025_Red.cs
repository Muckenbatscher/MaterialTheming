using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#782721";
    public string OnPrimary => "#FFCEC9";
    public string PrimaryContainer => "#B8574E";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#1F4856";
    public string OnSecondary => "#B8E0F1";
    public string SecondaryContainer => "#537A8A";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#004A59";
    public string OnTertiary => "#93E5FF";
    public string TertiaryContainer => "#008098";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#85112F";
    public string OnError => "#FFCDD1";
    public string ErrorContainer => "#C8475D";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F6";
    public string SurfaceVariant => "#FFDBD1";
    public string OnSurface => "#40170B";
    public string OnSurfaceVariant => "#673526";
    public string SurfaceDim => "#FFCFC2";
    public string SurfaceBright => "#FFF8F6";
    public string SurfaceTint => "#782721";
    // Background
    public string Background => "#FFF8F6";
    public string OnBackground => "#40170B";
    // Outline
    public string Outline => "#885140";
    public string OutlineVariant => "#A86B5A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#1E0803";
    public string InverseOnSurface => "#E9BAAD";
    public string InversePrimary => "#FF8E82";
    // Primary Fixed
    public string PrimaryFixed => "#B8574E";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#A94B43";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#537A8A";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#476D7D";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#008098";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#007289";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1ED";
    public string SurfaceContainer => "#FFE9E4";
    public string SurfaceContainerHigh => "#FFE2DA";
    public string SurfaceContainerHighest => "#FFDBD1";
}
