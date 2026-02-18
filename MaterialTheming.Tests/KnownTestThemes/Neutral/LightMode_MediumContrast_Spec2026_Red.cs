namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2026_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#4F3F3D";
    public string OnPrimary => "#ECD5D2";
    public string PrimaryContainer => "#83706E";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#494140";
    public string OnSecondary => "#E4D7D5";
    public string SecondaryContainer => "#7C7271";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#593A47";
    public string OnTertiary => "#FBCEDF";
    public string TertiaryContainer => "#8F6A79";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#7A2333";
    public string OnError => "#FFCDD1";
    public string ErrorContainer => "#B95463";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F7";
    public string SurfaceVariant => "#EBE0DF";
    public string OnSurface => "#282322";
    public string OnSurfaceVariant => "#484141";
    public string SurfaceDim => "#E3D7D6";
    public string SurfaceBright => "#FFF8F7";
    public string SurfaceTint => "#4F3F3D";
    // Background
    public string Background => "#FFF8F7";
    public string OnBackground => "#282322";
    // Outline
    public string Outline => "#655D5C";
    public string OutlineVariant => "#817978";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#100E0D";
    public string InverseOnSurface => "#CAC3C2";
    public string InversePrimary => "#FBE3E0";
    // Primary Fixed
    public string PrimaryFixed => "#83706E";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#766462";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#7C7271";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#6F6665";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#8F6A79";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#825E6D";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FAF2F1";
    public string SurfaceContainer => "#F5ECEB";
    public string SurfaceContainerHigh => "#F0E6E5";
    public string SurfaceContainerHighest => "#EBE0DF";
}
