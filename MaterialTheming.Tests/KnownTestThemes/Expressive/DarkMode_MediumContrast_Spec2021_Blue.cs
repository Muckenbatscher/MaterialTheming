namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#B9EAA1";
    public string OnPrimary => "#082D00";
    public string PrimaryContainer => "#6F9D5B";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFCFE4";
    public string OnSecondary => "#3B1B2C";
    public string SecondaryContainer => "#B18499";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#D4DBFF";
    public string OnTertiary => "#16234E";
    public string TertiaryContainer => "#838EC1";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#11131A";
    public string SurfaceVariant => "#444654";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DADBEC";
    public string SurfaceDim => "#11131A";
    public string SurfaceBright => "#43444C";
    public string SurfaceTint => "#A3D48D";
    // Background
    public string Background => "#11131A";
    public string OnBackground => "#E2E1EC";
    // Outline
    public string Outline => "#AFB1C1";
    public string OutlineVariant => "#8D8F9F";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E2E1EC";
    public string InverseOnSurface => "#282A31";
    public string InversePrimary => "#285119";
    // Primary Fixed
    public string PrimaryFixed => "#BFF0A6";
    public string OnPrimaryFixed => "#021500";
    public string PrimaryFixedDim => "#A3D48D";
    public string OnPrimaryFixedVariant => "#163F08";
    // Secondary Fixed
    public string SecondaryFixed => "#FFD8E8";
    public string OnSecondaryFixed => "#230717";
    public string SecondaryFixedDim => "#EBB8CF";
    public string OnSecondaryFixedVariant => "#4E2B3D";
    // Tertiary Fixed
    public string TertiaryFixed => "#DCE1FF";
    public string OnTertiaryFixed => "#000C39";
    public string TertiaryFixedDim => "#B8C4FA";
    public string OnTertiaryFixedVariant => "#273460";
    // Surface Container
    public string SurfaceContainerLowest => "#06070E";
    public string SurfaceContainerLow => "#1C1D25";
    public string SurfaceContainer => "#26272F";
    public string SurfaceContainerHigh => "#31323A";
    public string SurfaceContainerHighest => "#3C3D45";
}
