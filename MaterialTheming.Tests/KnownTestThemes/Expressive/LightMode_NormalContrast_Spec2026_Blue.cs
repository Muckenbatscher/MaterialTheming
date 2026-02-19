namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2026_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#2160A7";
    public string OnPrimary => "#F8F8FF";
    public string PrimaryContainer => "#9CC3FF";
    public string OnPrimaryContainer => "#003D74";
    // Secondary
    public string Secondary => "#416753";
    public string OnSecondary => "#E6FFEE";
    public string SecondaryContainer => "#D0FBE0";
    public string OnSecondaryContainer => "#3C624E";
    // Tertiary
    public string Tertiary => "#006E40";
    public string OnTertiary => "#E7FFEB";
    public string TertiaryContainer => "#9AFDBF";
    public string OnTertiaryContainer => "#006239";
    // Error
    public string Error => "#AC3434";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#F56965";
    public string OnErrorContainer => "#65000B";
    // Surface
    public string Surface => "#F9F9FF";
    public string SurfaceVariant => "#D5E3FF";
    public string OnSurface => "#193355";
    public string OnSurfaceVariant => "#486085";
    public string SurfaceDim => "#C7DBFF";
    public string SurfaceBright => "#F9F9FF";
    public string SurfaceTint => "#2160A7";
    // Background
    public string Background => "#F9F9FF";
    public string OnBackground => "#193355";
    // Outline
    public string Outline => "#647CA2";
    public string OutlineVariant => "#9BB3DC";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#030E20";
    public string InverseOnSurface => "#919DB4";
    public string InversePrimary => "#7EB2FF";
    // Primary Fixed
    public string PrimaryFixed => "#9CC3FF";
    public string OnPrimaryFixed => "#002850";
    public string PrimaryFixedDim => "#83B5FF";
    public string OnPrimaryFixedVariant => "#004684";
    // Secondary Fixed
    public string SecondaryFixed => "#D0FBE0";
    public string OnSecondaryFixed => "#2A4F3C";
    public string SecondaryFixedDim => "#C2ECD3";
    public string OnSecondaryFixedVariant => "#466C58";
    // Tertiary Fixed
    public string TertiaryFixed => "#9AFDBF";
    public string OnTertiaryFixed => "#004E2C";
    public string TertiaryFixedDim => "#8CEEB1";
    public string OnTertiaryFixedVariant => "#006E40";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F0F3FF";
    public string SurfaceContainer => "#E7EEFF";
    public string SurfaceContainerHigh => "#DEE9FF";
    public string SurfaceContainerHighest => "#D5E3FF";
}
