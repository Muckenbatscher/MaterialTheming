namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FF85C7";
    public string OnPrimary => "#5E0040";
    public string PrimaryContainer => "#FF6AC0";
    public string OnPrimaryContainer => "#490031";
    // Secondary
    public string Secondary => "#FD99EE";
    public string OnSecondary => "#651061";
    public string SecondaryContainer => "#762370";
    public string OnSecondaryContainer => "#FFBBF1";
    // Tertiary
    public string Tertiary => "#8EA0FF";
    public string OnTertiary => "#001A77";
    public string TertiaryContainer => "#7D91FA";
    public string OnTertiaryContainer => "#001056";
    // Error
    public string Error => "#FF6E84";
    public string OnError => "#490013";
    public string ErrorContainer => "#A70138";
    public string OnErrorContainer => "#FFB2B9";
    // Surface
    public string Surface => "#1F031D";
    public string SurfaceVariant => "#40143C";
    public string OnSurface => "#FFDBF4";
    public string OnSurfaceVariant => "#CC9DC1";
    public string SurfaceDim => "#1F031D";
    public string SurfaceBright => "#491945";
    public string SurfaceTint => "#FF85C7";
    // Background
    public string Background => "#1F031D";
    public string OnBackground => "#FFDBF4";
    // Outline
    public string Outline => "#92688A";
    public string OutlineVariant => "#613C5A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF7F9";
    public string InverseOnSurface => "#6F4868";
    public string InversePrimary => "#AD217B";
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
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#270524";
    public string SurfaceContainer => "#2F0A2C";
    public string SurfaceContainerHigh => "#380E34";
    public string SurfaceContainerHighest => "#40143C";
}
