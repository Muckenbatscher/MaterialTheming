namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2026_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#9D423A";
    public string OnPrimary => "#FFF7F6";
    public string PrimaryContainer => "#FFACA2";
    public string OnPrimaryContainer => "#70211C";
    // Secondary
    public string Secondary => "#3D6473";
    public string OnSecondary => "#F2FAFF";
    public string SecondaryContainer => "#C0E9FA";
    public string OnSecondaryContainer => "#2F5766";
    // Tertiary
    public string Tertiary => "#00687D";
    public string OnTertiary => "#F0FBFF";
    public string TertiaryContainer => "#58D6F7";
    public string OnTertiaryContainer => "#004756";
    // Error
    public string Error => "#AC3149";
    public string OnError => "#FFF7F7";
    public string ErrorContainer => "#F76A80";
    public string OnErrorContainer => "#68001F";
    // Surface
    public string Surface => "#FFF8F6";
    public string SurfaceVariant => "#FFDBD1";
    public string OnSurface => "#532518";
    public string OnSurfaceVariant => "#885140";
    public string SurfaceDim => "#FFCFC2";
    public string SurfaceBright => "#FFF8F6";
    public string SurfaceTint => "#9D423A";
    // Background
    public string Background => "#FFF8F6";
    public string OnBackground => "#532518";
    // Outline
    public string Outline => "#A86B5A";
    public string OutlineVariant => "#E7A18D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#1E0803";
    public string InverseOnSurface => "#BE9387";
    public string InversePrimary => "#FF8E82";
    // Primary Fixed
    public string PrimaryFixed => "#FFACA2";
    public string OnPrimaryFixed => "#530B09";
    public string PrimaryFixedDim => "#FF978C";
    public string OnPrimaryFixedVariant => "#7C2923";
    // Secondary Fixed
    public string SecondaryFixed => "#C0E9FA";
    public string OnSecondaryFixed => "#1B4452";
    public string SecondaryFixedDim => "#B2DBEC";
    public string OnSecondaryFixedVariant => "#3A6170";
    // Tertiary Fixed
    public string TertiaryFixed => "#58D6F7";
    public string OnTertiaryFixed => "#00313C";
    public string TertiaryFixedDim => "#46C8E9";
    public string OnTertiaryFixedVariant => "#005061";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1ED";
    public string SurfaceContainer => "#FFE9E4";
    public string SurfaceContainerHigh => "#FFE2DA";
    public string SurfaceContainerHighest => "#FFDBD1";
}
