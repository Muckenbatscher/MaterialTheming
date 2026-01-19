namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFECE9";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#FFAEA5";
    public string OnPrimaryContainer => "#220001";
    // Secondary
    public string Secondary => "#FFECE5";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#F0B69C";
    public string OnSecondaryContainer => "#1B0500";
    // Tertiary
    public string Tertiary => "#FFEDE0";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#F6B57E";
    public string OnTertiaryContainer => "#160800";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#1E100E";
    public string SurfaceVariant => "#58413F";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#1E100E";
    public string SurfaceBright => "#5F4B49";
    public string SurfaceTint => "#FFB4AB";
    // Background
    public string Background => "#1E100E";
    public string OnBackground => "#F9DCD9";
    // Outline
    public string Outline => "#FFECE9";
    public string OutlineVariant => "#DBBBB7";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F9DCD9";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#95000B";
    // Primary Fixed
    public string PrimaryFixed => "#FFDAD6";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FFB4AB";
    public string OnPrimaryFixedVariant => "#2D0001";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDBCD";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#F4B9A0";
    public string OnSecondaryFixedVariant => "#240800";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDCC2";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#FAB982";
    public string OnTertiaryFixedVariant => "#1F0C00";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2B1C1A";
    public string SurfaceContainer => "#3D2C2A";
    public string SurfaceContainerHigh => "#493735";
    public string SurfaceContainerHighest => "#554240";
}
