namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class LightMode_NormalContrast_Spec2026_Yellow_Blue : ITestThemeSecondSourceColor
{
    public string SourceColor => "#B2B037"; //Yellow
    public string SecondSourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#636200";
    public string OnPrimary => "#FFFCBB";
    public string PrimaryContainer => "#B2B037";
    public string OnPrimaryContainer => "#2F2E00";
    // Secondary
    public string Secondary => "#626132";
    public string OnSecondary => "#FFFCBE";
    public string SecondaryContainer => "#E8E5AA";
    public string OnSecondaryContainer => "#555426";
    // Tertiary
    public string Tertiary => "#00539B";
    public string OnTertiary => "#D6E4FF";
    public string TertiaryContainer => "#185FAA";
    public string OnTertiaryContainer => "#F6F7FF";
    // Error
    public string Error => "#9E422C";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#FE8B70";
    public string OnErrorContainer => "#5A1001";
    // Surface
    public string Surface => "#FEFAE3";
    public string SurfaceVariant => "#E7E4BD";
    public string OnSurface => "#343418";
    public string OnSurfaceVariant => "#626141";
    public string SurfaceDim => "#DFDCB5";
    public string SurfaceBright => "#FEFAE3";
    public string SurfaceTint => "#636200";
    // Background
    public string Background => "#FEFAE3";
    public string OnBackground => "#343418";
    // Outline
    public string Outline => "#7E7C5B";
    public string OutlineVariant => "#B6B48F";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0F0F00";
    public string InverseOnSurface => "#A09E89";
    public string InversePrimary => "#F6F473";
    // Primary Fixed
    public string PrimaryFixed => "#B2B037";
    public string OnPrimaryFixed => "#121100";
    public string PrimaryFixedDim => "#A4A22A";
    public string OnPrimaryFixedVariant => "#383700";
    // Secondary Fixed
    public string SecondaryFixed => "#E8E5AA";
    public string OnSecondaryFixed => "#424115";
    public string SecondaryFixedDim => "#DAD79D";
    public string OnSecondaryFixedVariant => "#5F5E2E";
    // Tertiary Fixed
    public string TertiaryFixed => "#185FAA";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#00539B";
    public string OnTertiaryFixedVariant => "#C5DAFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F8F5D7";
    public string SurfaceContainer => "#F2EFCE";
    public string SurfaceContainerHigh => "#EDEAC7";
    public string SurfaceContainerHighest => "#E7E4BD";
}
