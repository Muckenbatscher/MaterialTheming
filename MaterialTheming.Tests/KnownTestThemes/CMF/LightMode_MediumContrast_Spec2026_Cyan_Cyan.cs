namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class LightMode_MediumContrast_Spec2026_Cyan_Cyan : ITestThemeSecondSourceColor
{
    public string SourceColor => "#00BCD1"; //Cyan
    public string SecondSourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#004A53";
    public string OnPrimary => "#6DEBFF";
    public string PrimaryContainer => "#00818F";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#174951";
    public string OnSecondary => "#B2E2EB";
    public string SecondaryContainer => "#4E7C84";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#004A53";
    public string OnTertiary => "#91E7F6";
    public string TertiaryContainer => "#1D808E";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#7A2522";
    public string OnError => "#FFCECA";
    public string ErrorContainer => "#BB554F";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#EEFCFF";
    public string SurfaceVariant => "#CBE8ED";
    public string OnSurface => "#0C282C";
    public string OnSurfaceVariant => "#2D474C";
    public string SurfaceDim => "#C3DFE5";
    public string SurfaceBright => "#EEFCFF";
    public string SurfaceTint => "#004A53";
    // Background
    public string Background => "#EEFCFF";
    public string OnBackground => "#0C282C";
    // Outline
    public string Outline => "#496368";
    public string OutlineVariant => "#657F84";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#001114";
    public string InverseOnSurface => "#BAC7CA";
    public string InversePrimary => "#54E4F9";
    // Primary Fixed
    public string PrimaryFixed => "#00818F";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#007380";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#4E7C84";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#416F77";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#1D808E";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#007380";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#E4F7FB";
    public string SurfaceContainer => "#DCF2F6";
    public string SurfaceContainerHigh => "#D5ECF1";
    public string SurfaceContainerHighest => "#CBE8ED";
}
