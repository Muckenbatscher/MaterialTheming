namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#A91C78";
    public string OnPrimary => "#FFEFF3";
    public string PrimaryContainer => "#FF6AC0";
    public string OnPrimaryContainer => "#490031";
    // Secondary
    public string Secondary => "#8F3987";
    public string OnSecondary => "#FFEEF7";
    public string SecondaryContainer => "#FFBDF1";
    public string OnSecondaryContainer => "#772371";
    // Tertiary
    public string Tertiary => "#3E52B7";
    public string OnTertiary => "#F2F1FF";
    public string TertiaryContainer => "#9DABFF";
    public string OnTertiaryContainer => "#03228B";
    // Error
    public string Error => "#B41340";
    public string OnError => "#FFEFEF";
    public string ErrorContainer => "#F74B6D";
    public string OnErrorContainer => "#510017";
    // Surface
    public string Surface => "#FFF3F8";
    public string SurfaceVariant => "#FFCEF3";
    public string OnSurface => "#452340";
    public string OnSurfaceVariant => "#764F6F";
    public string SurfaceDim => "#FFC2F1";
    public string SurfaceBright => "#FFF3F8";
    public string SurfaceTint => "#A91C78";
    // Background
    public string Background => "#FFF3F8";
    public string OnBackground => "#452340";
    // Outline
    public string Outline => "#946A8B";
    public string OutlineVariant => "#CE9FC3";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#1F031D";
    public string InverseOnSurface => "#BC8FB2";
    public string InversePrimary => "#FA63BB";
    // Primary Fixed
    public string PrimaryFixed => "#FF6AC0";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#F05BB3";
    public string OnPrimaryFixedVariant => "#5A003D";
    // Secondary Fixed
    public string SecondaryFixed => "#FFBDF1";
    public string OnSecondaryFixed => "#60095C";
    public string SecondaryFixedDim => "#FFA6F0";
    public string OnSecondaryFixedVariant => "#822E7B";
    // Tertiary Fixed
    public string TertiaryFixed => "#9DABFF";
    public string OnTertiaryFixed => "#000E50";
    public string TertiaryFixedDim => "#8A9DFF";
    public string OnTertiaryFixedVariant => "#142D94";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFEBF7";
    public string SurfaceContainer => "#FFDFF5";
    public string SurfaceContainerHigh => "#FFD7F4";
    public string SurfaceContainerHighest => "#FFCEF3";
}
