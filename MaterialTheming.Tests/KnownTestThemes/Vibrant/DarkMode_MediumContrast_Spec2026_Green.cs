namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2026_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#63FC85";
    public string OnPrimary => "#00521E";
    public string PrimaryContainer => "#02BF51";
    public string OnPrimaryContainer => "#002108";
    // Secondary
    public string Secondary => "#7AF8B1";
    public string OnSecondary => "#005130";
    public string SecondaryContainer => "#008652";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#86ECFF";
    public string OnTertiary => "#004C56";
    public string TertiaryContainer => "#00E3FF";
    public string OnTertiaryContainer => "#00424C";
    // Error
    public string Error => "#FFA089";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#D53D18";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#001207";
    public string SurfaceVariant => "#002D18";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#94C4A4";
    public string SurfaceDim => "#001207";
    public string SurfaceBright => "#00341D";
    public string SurfaceTint => "#63FC85";
    // Background
    public string Background => "#001207";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#709E80";
    public string OutlineVariant => "#527F63";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E9FFED";
    public string InverseOnSurface => "#124029";
    public string InversePrimary => "#006326";
    // Primary Fixed
    public string PrimaryFixed => "#63FC85";
    public string OnPrimaryFixed => "#002309";
    public string PrimaryFixedDim => "#53ED79";
    public string OnPrimaryFixedVariant => "#00481A";
    // Secondary Fixed
    public string SecondaryFixed => "#7AF8B1";
    public string OnSecondaryFixed => "#002312";
    public string SecondaryFixedDim => "#6BE9A4";
    public string OnSecondaryFixedVariant => "#00472A";
    // Tertiary Fixed
    public string TertiaryFixed => "#00E3FF";
    public string OnTertiaryFixed => "#000A0D";
    public string TertiaryFixedDim => "#00D4EE";
    public string OnTertiaryFixedVariant => "#003840";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#00180A";
    public string SurfaceContainer => "#001F0F";
    public string SurfaceContainerHigh => "#002613";
    public string SurfaceContainerHighest => "#002D18";
}
