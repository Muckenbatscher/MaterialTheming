namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFECE8";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#FFAF9E";
    public string OnPrimaryContainer => "#200100";
    // Secondary
    public string Secondary => "#CDFAE5";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#A1CCB8";
    public string OnSecondaryContainer => "#000E08";
    // Tertiary
    public string Tertiary => "#B5FDFA";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#88CFCD";
    public string OnTertiaryContainer => "#000E0D";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#0D1511";
    public string SurfaceVariant => "#3B4A41";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#0D1511";
    public string SurfaceBright => "#49524C";
    public string SurfaceTint => "#FFB4A5";
    // Background
    public string Background => "#0D1511";
    public string OnBackground => "#DCE5DD";
    // Outline
    public string Outline => "#E3F4E8";
    public string OutlineVariant => "#B6C7BB";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#DCE5DD";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#783325";
    // Primary Fixed
    public string PrimaryFixed => "#FFDAD3";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FFB4A5";
    public string OnPrimaryFixedVariant => "#2B0200";
    // Secondary Fixed
    public string SecondaryFixed => "#C0ECD7";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#A4D0BC";
    public string OnSecondaryFixedVariant => "#00150D";
    // Tertiary Fixed
    public string TertiaryFixed => "#A8EFED";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#8CD3D1";
    public string OnTertiaryFixedVariant => "#001414";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#19211D";
    public string SurfaceContainer => "#2A322D";
    public string SurfaceContainerHigh => "#353D38";
    public string SurfaceContainerHighest => "#404943";
}
