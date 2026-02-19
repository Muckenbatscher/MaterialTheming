namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class LightMode_HighContrast_Spec2026_Cyan_Blue : ITestThemeSecondSourceColor
{
    public string SourceColor => "#00BCD1"; //Cyan
    public string SecondSourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#00282E";
    public string OnPrimary => "#70EBFF";
    public string PrimaryContainer => "#005B66";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#00282E";
    public string OnSecondary => "#B3E2EB";
    public string SecondaryContainer => "#2A5961";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#002449";
    public string OnTertiary => "#C7DBFF";
    public string TertiaryContainer => "#00529B";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#4F0407";
    public string OnError => "#FFCFCA";
    public string ErrorContainer => "#8E3430";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#EEFCFF";
    public string SurfaceVariant => "#CBE8ED";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#0C282C";
    public string SurfaceDim => "#C3DFE5";
    public string SurfaceBright => "#EEFCFF";
    public string SurfaceTint => "#00282E";
    // Background
    public string Background => "#EEFCFF";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#2D474C";
    public string OutlineVariant => "#3C565B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#001114";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#54E4F9";
    // Primary Fixed
    public string PrimaryFixed => "#005B66";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#004E58";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#2A5961";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#1C4D55";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#00529B";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#004786";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#E4F7FB";
    public string SurfaceContainer => "#DCF2F6";
    public string SurfaceContainerHigh => "#D5ECF1";
    public string SurfaceContainerHighest => "#CBE8ED";
}
