namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2026_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#503967";
    public string OnPrimary => "#EAD0FF";
    public string PrimaryContainer => "#846A9C";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#493F52";
    public string OnSecondary => "#E4D4ED";
    public string SecondaryContainer => "#7C7086";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#60354B";
    public string OnTertiary => "#FFCCE2";
    public string TertiaryContainer => "#98667E";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#821830";
    public string OnError => "#FFCDD1";
    public string ErrorContainer => "#C44B5F";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF7FE";
    public string SurfaceVariant => "#E9DFEB";
    public string OnSurface => "#27222B";
    public string OnSurfaceVariant => "#46414A";
    public string SurfaceDim => "#E0D7E3";
    public string SurfaceBright => "#FFF7FE";
    public string SurfaceTint => "#503967";
    // Background
    public string Background => "#FFF7FE";
    public string OnBackground => "#27222B";
    // Outline
    public string Outline => "#635D67";
    public string OutlineVariant => "#7F7883";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#100D11";
    public string InverseOnSurface => "#C9C3C9";
    public string InversePrimary => "#E4C6FE";
    // Primary Fixed
    public string PrimaryFixed => "#846A9C";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#775E8F";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#7C7086";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#706479";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#98667E";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#8A5971";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F9F1F9";
    public string SurfaceContainer => "#F4EBF5";
    public string SurfaceContainerHigh => "#EEE5F0";
    public string SurfaceContainerHighest => "#E9DFEB";
}
