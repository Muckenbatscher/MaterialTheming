namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_MediumContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFD4B2";
    public string OnPrimary => "#3C1E00";
    public string PrimaryContainer => "#CF7D2B";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFD4B2";
    public string OnSecondary => "#3C1E00";
    public string SecondaryContainer => "#C28349";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#E3E089";
    public string OnTertiary => "#282700";
    public string TertiaryContainer => "#969445";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#141407";
    public string SurfaceVariant => "#49482D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E1DEB9";
    public string SurfaceDim => "#141407";
    public string SurfaceBright => "#464535";
    public string SurfaceTint => "#FFB779";
    // Background
    public string Background => "#141407";
    public string OnBackground => "#E6E3CD";
    // Outline
    public string Outline => "#B6B391";
    public string OutlineVariant => "#949271";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E6E3CD";
    public string InverseOnSurface => "#2B2B1C";
    public string InversePrimary => "#6E3B00";
    // Primary Fixed
    public string PrimaryFixed => "#FFDCC1";
    public string OnPrimaryFixed => "#1F0C00";
    public string PrimaryFixedDim => "#FFB779";
    public string OnPrimaryFixedVariant => "#542C00";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDCC1";
    public string OnSecondaryFixed => "#1F0C00";
    public string SecondaryFixedDim => "#FFB779";
    public string OnSecondaryFixedVariant => "#542C00";
    // Tertiary Fixed
    public string TertiaryFixed => "#E9E78E";
    public string OnTertiaryFixed => "#121200";
    public string TertiaryFixedDim => "#CDCA75";
    public string OnTertiaryFixedVariant => "#393800";
    // Surface Container
    public string SurfaceContainerLowest => "#080801";
    public string SurfaceContainerLow => "#1F1E10";
    public string SurfaceContainer => "#29291A";
    public string SurfaceContainerHigh => "#343324";
    public string SurfaceContainerHighest => "#3F3E2E";
}
