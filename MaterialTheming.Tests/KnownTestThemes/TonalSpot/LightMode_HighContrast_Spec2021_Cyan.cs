using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#003138";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#00515B";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#173034";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#354D51";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#202B48";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#3E4867";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F5FAFC";
    public string SurfaceVariant => "#DBE4E6";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#B4BABB";
    public string SurfaceBright => "#F5FAFC";
    public string SurfaceTint => "#006875";
    // Background
    public string Background => "#F5FAFC";
    public string OnBackground => "#171D1E";
    // Outline
    public string Outline => "#252E2F";
    public string OutlineVariant => "#424B4D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2B3133";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#82D3E1";
    // Primary Fixed
    public string PrimaryFixed => "#00515B";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#003940";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#354D51";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#1E363B";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#3E4867";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#27324F";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#ECF2F3";
    public string SurfaceContainer => "#DEE3E5";
    public string SurfaceContainerHigh => "#D0D5D7";
    public string SurfaceContainerHighest => "#C2C7C9";
}
