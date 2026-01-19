namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#EBF0FF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#A5C3FF";
    public string OnPrimaryContainer => "#000B21";
    // Secondary
    public string Secondary => "#EDF5BE";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#C0C794";
    public string OnSecondaryContainer => "#090D00";
    // Tertiary
    public string Tertiary => "#D0FCC5";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#A3CE9A";
    public string OnTertiaryContainer => "#000F01";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#1C110D";
    public string SurfaceVariant => "#58423A";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#1C110D";
    public string SurfaceBright => "#5C4D47";
    public string SurfaceTint => "#ACC7FF";
    // Background
    public string Background => "#1C110D";
    public string OnBackground => "#F5DED6";
    // Outline
    public string Outline => "#FFECE6";
    public string OutlineVariant => "#DBBCB1";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F5DED6";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#244780";
    // Primary Fixed
    public string PrimaryFixed => "#D7E2FF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#ACC7FF";
    public string OnPrimaryFixedVariant => "#00102C";
    // Secondary Fixed
    public string SecondaryFixed => "#E0E7B1";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#C4CB97";
    public string OnSecondaryFixedVariant => "#0F1300";
    // Tertiary Fixed
    public string TertiaryFixed => "#C3EEB8";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#A7D29E";
    public string OnTertiaryFixedVariant => "#001601";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#291D18";
    public string SurfaceContainer => "#3B2D28";
    public string SurfaceContainerHigh => "#473833";
    public string SurfaceContainerHighest => "#53433E";
}
