namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_HighContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#CDF7FF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#4AD4E7";
    public string OnPrimaryContainer => "#000E10";
    // Secondary
    public string Secondary => "#CDF7FF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#7ECFDC";
    public string OnSecondaryContainer => "#000E10";
    // Tertiary
    public string Tertiary => "#EAF0FF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#A2C4FB";
    public string OnTertiaryContainer => "#000B1E";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#0E141C";
    public string SurfaceVariant => "#3D4758";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#0E141C";
    public string SurfaceBright => "#4B505A";
    public string SurfaceTint => "#4FD8EB";
    // Background
    public string Background => "#0E141C";
    public string OnBackground => "#DEE2EF";
    // Outline
    public string Outline => "#EAF0FF";
    public string OutlineVariant => "#B9C3D8";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#DEE2EF";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#005059";
    // Primary Fixed
    public string PrimaryFixed => "#98F0FF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#4FD8EB";
    public string OnPrimaryFixedVariant => "#001417";
    // Secondary Fixed
    public string SecondaryFixed => "#9EEFFD";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#82D3E0";
    public string OnSecondaryFixedVariant => "#001417";
    // Tertiary Fixed
    public string TertiaryFixed => "#D5E3FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#A6C8FF";
    public string OnTertiaryFixedVariant => "#001128";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1B2029";
    public string SurfaceContainer => "#2B313A";
    public string SurfaceContainerHigh => "#363C45";
    public string SurfaceContainerHighest => "#424751";
}
