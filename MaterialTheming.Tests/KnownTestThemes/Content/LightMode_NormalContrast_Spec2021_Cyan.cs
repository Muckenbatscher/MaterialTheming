using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_NormalContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#006875";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#00BCD1";
    public string OnPrimaryContainer => "#00464F";
    // Secondary
    public string Secondary => "#37656D";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#BBEBF4";
    public string OnSecondaryContainer => "#3D6B73";
    // Tertiary
    public string Tertiary => "#7C489A";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#CE94ED";
    public string OnTertiaryContainer => "#5A2678";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#F4FAFC";
    public string SurfaceVariant => "#D7E5E8";
    public string OnSurface => "#161D1E";
    public string OnSurfaceVariant => "#3C494B";
    public string SurfaceDim => "#D5DBDC";
    public string SurfaceBright => "#F4FAFC";
    public string SurfaceTint => "#006875";
    // Background
    public string Background => "#F4FAFC";
    public string OnBackground => "#161D1E";
    // Outline
    public string Outline => "#6C797C";
    public string OutlineVariant => "#BBC9CC";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2B3133";
    public string InverseOnSurface => "#ECF2F3";
    public string InversePrimary => "#45D8EE";
    // Primary Fixed
    public string PrimaryFixed => "#9AF0FF";
    public string OnPrimaryFixed => "#001F24";
    public string PrimaryFixedDim => "#45D8EE";
    public string OnPrimaryFixedVariant => "#004F58";
    // Secondary Fixed
    public string SecondaryFixed => "#BBEBF4";
    public string OnSecondaryFixed => "#001F24";
    public string SecondaryFixedDim => "#9FCED7";
    public string OnSecondaryFixedVariant => "#1C4D55";
    // Tertiary Fixed
    public string TertiaryFixed => "#F5D9FF";
    public string OnTertiaryFixed => "#30004A";
    public string TertiaryFixedDim => "#E6B4FF";
    public string OnTertiaryFixedVariant => "#632F80";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EFF5F6";
    public string SurfaceContainer => "#E9EFF0";
    public string SurfaceContainerHigh => "#E3E9EB";
    public string SurfaceContainerHighest => "#DDE4E5";
}
