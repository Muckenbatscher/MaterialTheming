using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#442A5F";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#7E619A";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#3C3245";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#75697E";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#522A30";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#916066";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF7FE";
    public string SurfaceVariant => "#E9DFEB";
    public string OnSurface => "#131015";
    public string OnSurfaceVariant => "#39343D";
    public string SurfaceDim => "#CBC4CC";
    public string SurfaceBright => "#FFF7FE";
    public string SurfaceTint => "#6E528A";
    // Background
    public string Background => "#FFF7FE";
    public string OnBackground => "#1E1A20";
    // Outline
    public string Outline => "#565059";
    public string OutlineVariant => "#716B74";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#332F35";
    public string InverseOnSurface => "#F6EEF6";
    public string InversePrimary => "#DBB9F9";
    // Primary Fixed
    public string PrimaryFixed => "#7E619A";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#644980";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#75697E";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#5C5065";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#916066";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#75484E";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F9F1F9";
    public string SurfaceContainer => "#EEE6EE";
    public string SurfaceContainerHigh => "#E2DAE2";
    public string SurfaceContainerHighest => "#D7CFD7";
}
