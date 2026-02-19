namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class LightMode_MediumContrast_Spec2026_Yellow_Magenta : ITestThemeSecondSourceColor
{
    public string SourceColor => "#B2B037"; //Yellow
    public string SecondSourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#464500";
    public string OnPrimary => "#E1DF61";
    public string PrimaryContainer => "#7A7800";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#454518";
    public string OnSecondary => "#DFDDA1";
    public string SecondaryContainer => "#787745";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#83005B";
    public string OnTertiary => "#FFCCE2";
    public string TertiaryContainer => "#C54091";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#7A2522";
    public string OnError => "#FFCECA";
    public string ErrorContainer => "#BB554F";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FEFAE3";
    public string SurfaceVariant => "#E7E4BD";
    public string OnSurface => "#25250B";
    public string OnSurfaceVariant => "#454427";
    public string SurfaceDim => "#DFDCB5";
    public string SurfaceBright => "#FEFAE3";
    public string SurfaceTint => "#464500";
    // Background
    public string Background => "#FEFAE3";
    public string OnBackground => "#25250B";
    // Outline
    public string Outline => "#626141";
    public string OutlineVariant => "#7E7C5B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0F0F00";
    public string InverseOnSurface => "#C8C5B0";
    public string InversePrimary => "#F6F473";
    // Primary Fixed
    public string PrimaryFixed => "#7A7800";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#6D6B00";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#787745";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#6C6A3A";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#C54091";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#B53383";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F8F5D7";
    public string SurfaceContainer => "#F2EFCE";
    public string SurfaceContainerHigh => "#EDEAC7";
    public string SurfaceContainerHighest => "#E7E4BD";
}
