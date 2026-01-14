using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FF98CE";
    public string OnPrimary => "#5A003D";
    public string PrimaryContainer => "#FF6AC0";
    public string OnPrimaryContainer => "#30001F";
    // Secondary
    public string Secondary => "#FD99EE";
    public string OnSecondary => "#580055";
    public string SecondaryContainer => "#AC53A2";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#A8B4FF";
    public string OnTertiary => "#001D82";
    public string TertiaryContainer => "#8397FF";
    public string OnTertiaryContainer => "#00093E";
    // Error
    public string Error => "#FF9DA8";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#D73357";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#1F031D";
    public string SurfaceVariant => "#40143C";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DAAACF";
    public string SurfaceDim => "#1F031D";
    public string SurfaceBright => "#491945";
    public string SurfaceTint => "#FF98CE";
    // Background
    public string Background => "#1F031D";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#B286A9";
    public string OutlineVariant => "#92688A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF7F9";
    public string InverseOnSurface => "#4F2C4A";
    public string InversePrimary => "#A01171";
    // Primary Fixed
    public string PrimaryFixed => "#FF6AC0";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#F05BB3";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#FFBDF1";
    public string OnSecondaryFixed => "#20001F";
    public string SecondaryFixedDim => "#FFA6F0";
    public string OnSecondaryFixedVariant => "#60095C";
    // Tertiary Fixed
    public string TertiaryFixed => "#9DABFF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#8A9DFF";
    public string OnTertiaryFixedVariant => "#000E50";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#270524";
    public string SurfaceContainer => "#2F0A2C";
    public string SurfaceContainerHigh => "#380E34";
    public string SurfaceContainerHighest => "#40143C";
}
