namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FDA49A";
    public string OnPrimary => "#541C17";
    public string PrimaryContainer => "#AA6058";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#B3CAD5";
    public string OnSecondary => "#243942";
    public string SecondaryContainer => "#627881";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#7FE2FF";
    public string OnTertiary => "#004655";
    public string TertiaryContainer => "#58D6F7";
    public string OnTertiaryContainer => "#003C49";
    // Error
    public string Error => "#FF9DA8";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#C8475D";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#1B0905";
    public string SurfaceVariant => "#3E1C12";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E4AC9C";
    public string SurfaceDim => "#1B0905";
    public string SurfaceBright => "#472116";
    public string SurfaceTint => "#FDA49A";
    // Background
    public string Background => "#1B0905";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#BB8779";
    public string OutlineVariant => "#996A5C";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F6";
    public string InverseOnSurface => "#4B322B";
    public string InversePrimary => "#84413B";
    // Primary Fixed
    public string PrimaryFixed => "#FFACA2";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#F49C93";
    public string OnPrimaryFixedVariant => "#4B1511";
    // Secondary Fixed
    public string SecondaryFixed => "#DAF2FD";
    public string OnSecondaryFixed => "#152B33";
    public string SecondaryFixedDim => "#CCE3EE";
    public string OnSecondaryFixedVariant => "#344952";
    // Tertiary Fixed
    public string TertiaryFixed => "#58D6F7";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#46C8E9";
    public string OnTertiaryFixedVariant => "#00313C";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#230D07";
    public string SurfaceContainer => "#2C130B";
    public string SurfaceContainerHigh => "#35170F";
    public string SurfaceContainerHighest => "#3E1C12";
}
