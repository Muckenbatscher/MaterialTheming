namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#98E9F8";
    public string OnPrimary => "#002A30";
    public string PrimaryContainer => "#499CAA";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#C7E1E6";
    public string OnSecondary => "#10292D";
    public string SecondaryContainer => "#7C959A";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#D1DBFF";
    public string OnTertiary => "#192541";
    public string TertiaryContainer => "#8590B2";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#0E1416";
    public string SurfaceVariant => "#3F484A";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#D4DEE0";
    public string SurfaceDim => "#0E1416";
    public string SurfaceBright => "#3F4647";
    public string SurfaceTint => "#82D3E1";
    // Background
    public string Background => "#0E1416";
    public string OnBackground => "#DEE3E5";
    // Outline
    public string Outline => "#AAB4B6";
    public string OutlineVariant => "#889294";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#DEE3E5";
    public string InverseOnSurface => "#252B2C";
    public string InversePrimary => "#00505A";
    // Primary Fixed
    public string PrimaryFixed => "#9EEFFE";
    public string OnPrimaryFixed => "#001417";
    public string PrimaryFixedDim => "#82D3E1";
    public string OnPrimaryFixedVariant => "#003C44";
    // Secondary Fixed
    public string SecondaryFixed => "#CDE7EC";
    public string OnSecondaryFixed => "#001417";
    public string SecondaryFixedDim => "#B1CBD0";
    public string OnSecondaryFixedVariant => "#223A3E";
    // Tertiary Fixed
    public string TertiaryFixed => "#DAE2FF";
    public string OnTertiaryFixed => "#04102C";
    public string TertiaryFixedDim => "#BBC6EA";
    public string OnTertiaryFixedVariant => "#2A3553";
    // Surface Container
    public string SurfaceContainerLowest => "#040809";
    public string SurfaceContainerLow => "#191F20";
    public string SurfaceContainer => "#23292A";
    public string SurfaceContainerHigh => "#2E3435";
    public string SurfaceContainerHighest => "#393F40";
}
