namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#F9ECFE";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#CABFD0";
    public string OnPrimaryContainer => "#0F0914";
    // Secondary
    public string Secondary => "#F7EDF8";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#C8C0CB";
    public string OnSecondaryContainer => "#0D0A11";
    // Tertiary
    public string Tertiary => "#F9EBFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#CCBDD6";
    public string OnTertiaryContainer => "#100818";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#141314";
    public string SurfaceVariant => "#484648";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#141314";
    public string SurfaceBright => "#524F51";
    public string SurfaceTint => "#CEC2D4";
    // Background
    public string Background => "#141314";
    public string OnBackground => "#E6E1E3";
    // Outline
    public string Outline => "#F4EFF0";
    public string OutlineVariant => "#C6C1C3";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E6E1E3";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#4D4553";
    // Primary Fixed
    public string PrimaryFixed => "#EBDEF0";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#CEC2D4";
    public string OnPrimaryFixedVariant => "#150F1B";
    // Secondary Fixed
    public string SecondaryFixed => "#E9DFEB";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#CCC4CE";
    public string OnSecondaryFixedVariant => "#141017";
    // Tertiary Fixed
    public string TertiaryFixed => "#EDDDF6";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#D0C1DA";
    public string OnTertiaryFixedVariant => "#160D1F";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#211F21";
    public string SurfaceContainer => "#323031";
    public string SurfaceContainerHigh => "#3D3B3C";
    public string SurfaceContainerHighest => "#484648";
}
