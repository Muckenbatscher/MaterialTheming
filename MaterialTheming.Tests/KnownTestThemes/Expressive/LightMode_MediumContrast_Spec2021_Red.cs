namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#0A356D";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#4C6DA8";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#333913";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#6A7145";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#1A3E18";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#50764A";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F6";
    public string SurfaceVariant => "#FDDCD0";
    public string OnSurface => "#190F0A";
    public string OnSurfaceVariant => "#46312A";
    public string SurfaceDim => "#D8C2BB";
    public string SurfaceBright => "#FFF8F6";
    public string SurfaceTint => "#3D5E98";
    // Background
    public string Background => "#FFF8F6";
    public string OnBackground => "#251914";
    // Outline
    public string Outline => "#644D45";
    public string OutlineVariant => "#81675E";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#3B2D28";
    public string InverseOnSurface => "#FFEDE7";
    public string InversePrimary => "#ACC7FF";
    // Primary Fixed
    public string PrimaryFixed => "#4C6DA8";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#32548E";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#6A7145";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#52582F";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#50764A";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#385D34";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1EC";
    public string SurfaceContainer => "#FBE3DC";
    public string SurfaceContainerHigh => "#EFD8D0";
    public string SurfaceContainerHighest => "#E3CDC5";
}
