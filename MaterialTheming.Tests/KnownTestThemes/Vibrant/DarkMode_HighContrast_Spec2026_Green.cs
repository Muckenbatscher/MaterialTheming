namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2026_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#83FF97";
    public string OnPrimary => "#003411";
    public string PrimaryContainer => "#02BF51";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#80FEB7";
    public string OnSecondary => "#00341D";
    public string SecondaryContainer => "#34B979";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#ABF1FF";
    public string OnTertiary => "#003138";
    public string TertiaryContainer => "#00E3FF";
    public string OnTertiaryContainer => "#001E23";
    // Error
    public string Error => "#FFDED7";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#FF7E5E";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#001207";
    public string SurfaceVariant => "#002D18";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#C0F1CF";
    public string SurfaceDim => "#001207";
    public string SurfaceBright => "#00341D";
    public string SurfaceTint => "#83FF97";
    // Background
    public string Background => "#001207";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#94C4A4";
    public string OutlineVariant => "#80AE8F";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E9FFED";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#004217";
    // Primary Fixed
    public string PrimaryFixed => "#63FC85";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#53ED79";
    public string OnPrimaryFixedVariant => "#002309";
    // Secondary Fixed
    public string SecondaryFixed => "#7AF8B1";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#6BE9A4";
    public string OnSecondaryFixedVariant => "#002312";
    // Tertiary Fixed
    public string TertiaryFixed => "#00E3FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#00D4EE";
    public string OnTertiaryFixedVariant => "#000A0D";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#00180A";
    public string SurfaceContainer => "#001F0F";
    public string SurfaceContainerHigh => "#002613";
    public string SurfaceContainerHighest => "#002D18";
}
