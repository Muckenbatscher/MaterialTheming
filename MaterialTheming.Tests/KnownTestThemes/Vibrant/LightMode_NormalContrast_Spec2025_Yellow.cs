namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#605E00";
    public string OnPrimary => "#FDFA04";
    public string PrimaryContainer => "#F5F200";
    public string OnPrimaryContainer => "#5B5A00";
    // Secondary
    public string Secondary => "#6D5A00";
    public string OnSecondary => "#FFF2CE";
    public string SecondaryContainer => "#FCD83F";
    public string OnSecondaryContainer => "#5B4B00";
    // Tertiary
    public string Tertiary => "#755700";
    public string OnTertiary => "#FFF1DB";
    public string TertiaryContainer => "#F7BE26";
    public string OnTertiaryContainer => "#533D00";
    // Error
    public string Error => "#B02500";
    public string OnError => "#FFEFEC";
    public string ErrorContainer => "#F95630";
    public string OnErrorContainer => "#520C00";
    // Surface
    public string Surface => "#FFF6E1";
    public string SurfaceVariant => "#F5DC81";
    public string OnSurface => "#392E00";
    public string OnSurfaceVariant => "#695B23";
    public string SurfaceDim => "#EDD374";
    public string SurfaceBright => "#FFF6E1";
    public string SurfaceTint => "#605E00";
    // Background
    public string Background => "#FFF6E1";
    public string OnBackground => "#392E00";
    // Outline
    public string Outline => "#86763B";
    public string OutlineVariant => "#BFAC6C";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#130E00";
    public string InverseOnSurface => "#AE9C5E";
    public string InversePrimary => "#FEFB07";
    // Primary Fixed
    public string PrimaryFixed => "#F5F200";
    public string OnPrimaryFixed => "#484700";
    public string PrimaryFixedDim => "#E6E300";
    public string OnPrimaryFixedVariant => "#656400";
    // Secondary Fixed
    public string SecondaryFixed => "#FCD83F";
    public string OnSecondaryFixed => "#463900";
    public string SecondaryFixedDim => "#EDCA30";
    public string OnSecondaryFixedVariant => "#665500";
    // Tertiary Fixed
    public string TertiaryFixed => "#F7BE26";
    public string OnTertiaryFixed => "#3A2900";
    public string TertiaryFixedDim => "#E8B013";
    public string OnTertiaryFixedVariant => "#5E4500";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0C4";
    public string SurfaceContainer => "#FFE796";
    public string SurfaceContainerHigh => "#FAE18C";
    public string SurfaceContainerHighest => "#F5DC81";
}
