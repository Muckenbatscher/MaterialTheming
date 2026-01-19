namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#CFCC00";
    public string OnPrimary => "#333200";
    public string PrimaryContainer => "#4A4900";
    public string OnPrimaryContainer => "#ECE900";
    // Secondary
    public string Secondary => "#C2CC99";
    public string OnSecondary => "#2C340F";
    public string SecondaryContainer => "#424A23";
    public string OnSecondaryContainer => "#DEE8B3";
    // Tertiary
    public string Tertiary => "#B1D094";
    public string OnTertiary => "#1E370A";
    public string TertiaryContainer => "#344E1F";
    public string OnTertiaryContainer => "#CCEDAE";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#141407";
    public string SurfaceVariant => "#494833";
    public string OnSurface => "#E6E3CD";
    public string OnSurfaceVariant => "#CAC7AD";
    public string SurfaceDim => "#141407";
    public string SurfaceBright => "#3B3A2A";
    public string SurfaceTint => "#CFCC00";
    // Background
    public string Background => "#141407";
    public string OnBackground => "#E6E3CD";
    // Outline
    public string Outline => "#94927A";
    public string OutlineVariant => "#494833";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E6E3CD";
    public string InverseOnSurface => "#323122";
    public string InversePrimary => "#636100";
    // Primary Fixed
    public string PrimaryFixed => "#ECE900";
    public string OnPrimaryFixed => "#1D1D00";
    public string PrimaryFixedDim => "#CFCC00";
    public string OnPrimaryFixedVariant => "#4A4900";
    // Secondary Fixed
    public string SecondaryFixed => "#DEE8B3";
    public string OnSecondaryFixed => "#171E00";
    public string SecondaryFixedDim => "#C2CC99";
    public string OnSecondaryFixedVariant => "#424A23";
    // Tertiary Fixed
    public string TertiaryFixed => "#CCEDAE";
    public string OnTertiaryFixed => "#0C2000";
    public string TertiaryFixedDim => "#B1D094";
    public string OnTertiaryFixedVariant => "#344E1F";
    // Surface Container
    public string SurfaceContainerLowest => "#0F0F04";
    public string SurfaceContainerLow => "#1D1C0E";
    public string SurfaceContainer => "#212012";
    public string SurfaceContainerHigh => "#2B2B1C";
    public string SurfaceContainerHighest => "#363526";
}
