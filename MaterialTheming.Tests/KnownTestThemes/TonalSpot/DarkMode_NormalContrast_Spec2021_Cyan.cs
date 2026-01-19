namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#82D3E1";
    public string OnPrimary => "#00363D";
    public string PrimaryContainer => "#004F58";
    public string OnPrimaryContainer => "#9EEFFE";
    // Secondary
    public string Secondary => "#B1CBD0";
    public string OnSecondary => "#1C3438";
    public string SecondaryContainer => "#334B4F";
    public string OnSecondaryContainer => "#CDE7EC";
    // Tertiary
    public string Tertiary => "#BBC6EA";
    public string OnTertiary => "#252F4D";
    public string TertiaryContainer => "#3B4665";
    public string OnTertiaryContainer => "#DAE2FF";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#0E1416";
    public string SurfaceVariant => "#3F484A";
    public string OnSurface => "#DEE3E5";
    public string OnSurfaceVariant => "#BFC8CA";
    public string SurfaceDim => "#0E1416";
    public string SurfaceBright => "#343A3B";
    public string SurfaceTint => "#82D3E1";
    // Background
    public string Background => "#0E1416";
    public string OnBackground => "#DEE3E5";
    // Outline
    public string Outline => "#899294";
    public string OutlineVariant => "#3F484A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#DEE3E5";
    public string InverseOnSurface => "#2B3133";
    public string InversePrimary => "#006875";
    // Primary Fixed
    public string PrimaryFixed => "#9EEFFE";
    public string OnPrimaryFixed => "#001F24";
    public string PrimaryFixedDim => "#82D3E1";
    public string OnPrimaryFixedVariant => "#004F58";
    // Secondary Fixed
    public string SecondaryFixed => "#CDE7EC";
    public string OnSecondaryFixed => "#051F23";
    public string SecondaryFixedDim => "#B1CBD0";
    public string OnSecondaryFixedVariant => "#334B4F";
    // Tertiary Fixed
    public string TertiaryFixed => "#DAE2FF";
    public string OnTertiaryFixed => "#0F1A37";
    public string TertiaryFixedDim => "#BBC6EA";
    public string OnTertiaryFixedVariant => "#3B4665";
    // Surface Container
    public string SurfaceContainerLowest => "#090F10";
    public string SurfaceContainerLow => "#171D1E";
    public string SurfaceContainer => "#1B2122";
    public string SurfaceContainerHigh => "#252B2C";
    public string SurfaceContainerHighest => "#303637";
}
