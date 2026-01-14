using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#673615";
    public string OnPrimary => "#FFD0B6";
    public string PrimaryContainer => "#A26641";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#573D2D";
    public string OnSecondary => "#F9D2BC";
    public string SecondaryContainer => "#8E6E5C";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#4E420C";
    public string OnTertiary => "#EBD995";
    public string TertiaryContainer => "#82743A";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#801F07";
    public string OnError => "#FFCFC4";
    public string ErrorContainer => "#C44F34";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F5";
    public string SurfaceVariant => "#F5DED2";
    public string OnSurface => "#2E211A";
    public string OnSurfaceVariant => "#4F4038";
    public string SurfaceDim => "#ECD6CA";
    public string SurfaceBright => "#FFF8F5";
    public string SurfaceTint => "#673615";
    // Background
    public string Background => "#FFF8F5";
    public string OnBackground => "#2E211A";
    // Outline
    public string Outline => "#6C5C53";
    public string OutlineVariant => "#89776D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#130D09";
    public string InverseOnSurface => "#D0C2BC";
    public string InversePrimary => "#FFB68B";
    // Primary Fixed
    public string PrimaryFixed => "#A26641";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#935A36";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#8E6E5C";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#806250";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#82743A";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#75682F";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1EA";
    public string SurfaceContainer => "#FEEAE0";
    public string SurfaceContainerHigh => "#F9E4DA";
    public string SurfaceContainerHighest => "#F5DED2";
}
