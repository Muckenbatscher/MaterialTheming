using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#006875";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#9EEFFE";
    public string OnPrimaryContainer => "#004F58";
    // Secondary
    public string Secondary => "#4A6267";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#CDE7EC";
    public string OnSecondaryContainer => "#334B4F";
    // Tertiary
    public string Tertiary => "#535E7E";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#DAE2FF";
    public string OnTertiaryContainer => "#3B4665";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#F5FAFC";
    public string SurfaceVariant => "#DBE4E6";
    public string OnSurface => "#171D1E";
    public string OnSurfaceVariant => "#3F484A";
    public string SurfaceDim => "#D5DBDC";
    public string SurfaceBright => "#F5FAFC";
    public string SurfaceTint => "#006875";
    // Background
    public string Background => "#F5FAFC";
    public string OnBackground => "#171D1E";
    // Outline
    public string Outline => "#6F797B";
    public string OutlineVariant => "#BFC8CA";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2B3133";
    public string InverseOnSurface => "#ECF2F3";
    public string InversePrimary => "#82D3E1";
    // Primary Fixed
    public string PrimaryFixed => "#9EEFFE";
    public string OnPrimaryFixed => "#001F24";
    public string PrimaryFixedDim => "#82D3E1";
    public string OnPrimaryFixedVariant => "#004F58";
    // Secondary Fixed
    public string SecondaryFixed => "#CDE7EC";
    public string OnSecondaryFixed => "#051F23";
    public string SecondaryFixedDim => "#B1CBD0";
    public string OnSecondaryFixedVariant => "#334B4F";
    // Tertiary Fixed
    public string TertiaryFixed => "#DAE2FF";
    public string OnTertiaryFixed => "#0F1A37";
    public string TertiaryFixedDim => "#BBC6EA";
    public string OnTertiaryFixedVariant => "#3B4665";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EFF5F6";
    public string SurfaceContainer => "#E9EFF0";
    public string SurfaceContainerHigh => "#E3E9EA";
    public string SurfaceContainerHighest => "#DEE3E5";
}
