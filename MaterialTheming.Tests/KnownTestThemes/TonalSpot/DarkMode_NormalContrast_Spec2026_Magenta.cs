namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2026_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#EEB7D0";
    public string OnPrimary => "#5B3448";
    public string PrimaryContainer => "#70465B";
    public string OnPrimaryContainer => "#FFD9E9";
    // Secondary
    public string Secondary => "#E0BDCC";
    public string OnSecondary => "#513945";
    public string SecondaryContainer => "#4C3540";
    public string OnSecondaryContainer => "#D8B6C4";
    // Tertiary
    public string Tertiary => "#F9E0FF";
    public string OnTertiary => "#664B72";
    public string TertiaryContainer => "#F0CEFD";
    public string OnTertiaryContainer => "#5D4369";
    // Error
    public string Error => "#F97386";
    public string OnError => "#490013";
    public string ErrorContainer => "#871C34";
    public string OnErrorContainer => "#FF97A3";
    // Surface
    public string Surface => "#120D0F";
    public string SurfaceVariant => "#2E2328";
    public string OnSurface => "#F4E0E7";
    public string OnSurfaceVariant => "#B8A6AD";
    public string SurfaceDim => "#120D0F";
    public string SurfaceBright => "#35292E";
    public string SurfaceTint => "#EEB7D0";
    // Background
    public string Background => "#120D0F";
    public string OnBackground => "#F4E0E7";
    // Outline
    public string Outline => "#817177";
    public string OutlineVariant => "#52444A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F8";
    public string InverseOnSurface => "#5B5356";
    public string InversePrimary => "#7E5268";
    // Primary Fixed
    public string PrimaryFixed => "#F7BFD9";
    public string OnPrimaryFixed => "#4B263A";
    public string PrimaryFixedDim => "#E8B2CB";
    public string OnPrimaryFixedVariant => "#6C4257";
    // Secondary Fixed
    public string SecondaryFixed => "#FDD9E8";
    public string OnSecondaryFixed => "#503844";
    public string SecondaryFixedDim => "#EECBDA";
    public string OnSecondaryFixedVariant => "#6F5460";
    // Tertiary Fixed
    public string TertiaryFixed => "#F0CEFD";
    public string OnTertiaryFixed => "#493055";
    public string TertiaryFixedDim => "#E2C1EE";
    public string OnTertiaryFixedVariant => "#674C73";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#191115";
    public string SurfaceContainer => "#20171B";
    public string SurfaceContainerHigh => "#271D21";
    public string SurfaceContainerHighest => "#2E2328";
}
