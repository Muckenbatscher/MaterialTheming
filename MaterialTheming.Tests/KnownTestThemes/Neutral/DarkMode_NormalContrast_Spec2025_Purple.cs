namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#CCC4CE";
    public string OnPrimary => "#443E47";
    public string PrimaryContainer => "#4A454E";
    public string OnPrimaryContainer => "#D6CDD8";
    // Secondary
    public string Secondary => "#A19CA1";
    public string OnSecondary => "#221F23";
    public string SecondaryContainer => "#3D3A3E";
    public string OnSecondaryContainer => "#C3BEC2";
    // Tertiary
    public string Tertiary => "#EFE7FF";
    public string OnTertiary => "#59536F";
    public string TertiaryContainer => "#E1D8FA";
    public string OnTertiaryContainer => "#504B66";
    // Error
    public string Error => "#EC7C8A";
    public string OnError => "#490013";
    public string ErrorContainer => "#7F2737";
    public string OnErrorContainer => "#FF97A3";
    // Surface
    public string Surface => "#0F0E0F";
    public string SurfaceVariant => "#272528";
    public string OnSurface => "#EAE4E7";
    public string OnSurfaceVariant => "#AEAAAD";
    public string SurfaceDim => "#0F0E0F";
    public string SurfaceBright => "#2E2B2E";
    public string SurfaceTint => "#CCC4CE";
    // Background
    public string Background => "#0F0E0F";
    public string OnBackground => "#EAE4E7";
    // Outline
    public string Outline => "#787477";
    public string OutlineVariant => "#4A474A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FDF8F9";
    public string InverseOnSurface => "#575455";
    public string InversePrimary => "#635D66";
    // Primary Fixed
    public string PrimaryFixed => "#E9DFEB";
    public string OnPrimaryFixed => "#433D46";
    public string PrimaryFixedDim => "#DBD1DC";
    public string OnPrimaryFixedVariant => "#5F5963";
    // Secondary Fixed
    public string SecondaryFixed => "#E7E1E5";
    public string OnSecondaryFixed => "#413E42";
    public string SecondaryFixedDim => "#D9D3D7";
    public string OnSecondaryFixedVariant => "#5E5A5E";
    // Tertiary Fixed
    public string TertiaryFixed => "#E1D8FA";
    public string OnTertiaryFixed => "#3D3852";
    public string TertiaryFixedDim => "#D3CAEB";
    public string OnTertiaryFixedVariant => "#5A5470";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#141314";
    public string SurfaceContainer => "#1B191B";
    public string SurfaceContainerHigh => "#211F21";
    public string SurfaceContainerHighest => "#272528";
}
