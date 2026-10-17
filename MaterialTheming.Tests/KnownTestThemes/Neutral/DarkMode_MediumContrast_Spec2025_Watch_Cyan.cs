namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2025_Watch_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FEFFFF";
    public string OnPrimary => "#122225";
    public string PrimaryContainer => "#78898C";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FEFFFF";
    public string OnSecondary => "#1A2022";
    public string SecondaryContainer => "#818788";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#000F18";
    public string TertiaryContainer => "#7FBEE3";
    public string OnTertiaryContainer => "#002E41";
    // Error
    public string Error => "#FFBEB9";
    public string OnError => "#3A0406";
    public string ErrorContainer => "#C46D68";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#16292C";
    public string OnSurface => "#FEFFFF";
    public string OnSurfaceVariant => "#C9CFD0";
    public string SurfaceDim => "#090F10";
    public string SurfaceBright => "#192F33";
    public string SurfaceTint => "#FEFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#A1A7A8";
    public string OutlineVariant => "#818788";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F5FAFC";
    public string InverseOnSurface => "#33393A";
    public string InversePrimary => "#2B3B3E";
    // Primary Fixed
    public string PrimaryFixed => "#D4E6E9";
    public string OnPrimaryFixed => "#122225";
    public string PrimaryFixedDim => "#C6D8DB";
    public string OnPrimaryFixedVariant => "#324245";
    // Secondary Fixed
    public string SecondaryFixed => "#DEE3E5";
    public string OnSecondaryFixed => "#1A2022";
    public string SecondaryFixedDim => "#D0D5D7";
    public string OnSecondaryFixedVariant => "#3A4042";
    // Tertiary Fixed
    public string TertiaryFixed => "#9CD9FF";
    public string OnTertiaryFixed => "#000F18";
    public string TertiaryFixedDim => "#8DCBF1";
    public string OnTertiaryFixedVariant => "#00394F";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#212728";
    public string SurfaceContainer => "#2B3133";
    public string SurfaceContainerHigh => "#363C3E";
    public string SurfaceContainerHighest => "#16292C";
}
