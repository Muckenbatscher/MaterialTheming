namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#B2EAB3";
    public string OnPrimary => "#002D0D";
    public string PrimaryContainer => "#689D6C";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#CEE2CB";
    public string OnSecondary => "#19291A";
    public string SecondaryContainer => "#839681";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#B7E4ED";
    public string OnTertiary => "#002A30";
    public string TertiaryContainer => "#6C98A0";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#101510";
    public string SurfaceVariant => "#424940";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#D7DED3";
    public string SurfaceDim => "#101510";
    public string SurfaceBright => "#414640";
    public string SurfaceTint => "#9CD49F";
    // Background
    public string Background => "#101510";
    public string OnBackground => "#E0E4DB";
    // Outline
    public string Outline => "#ADB4A9";
    public string OutlineVariant => "#8B9288";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E0E4DB";
    public string InverseOnSurface => "#272B26";
    public string InversePrimary => "#1F5229";
    // Primary Fixed
    public string PrimaryFixed => "#B8F1B9";
    public string OnPrimaryFixed => "#001504";
    public string PrimaryFixedDim => "#9CD49F";
    public string OnPrimaryFixedVariant => "#083F18";
    // Secondary Fixed
    public string SecondaryFixed => "#D4E8D1";
    public string OnSecondaryFixed => "#051407";
    public string SecondaryFixedDim => "#B8CCB5";
    public string OnSecondaryFixedVariant => "#2A3A2A";
    // Tertiary Fixed
    public string TertiaryFixed => "#BDEAF3";
    public string OnTertiaryFixed => "#001417";
    public string TertiaryFixedDim => "#A1CED6";
    public string OnTertiaryFixedVariant => "#083C43";
    // Surface Container
    public string SurfaceContainerLowest => "#050805";
    public string SurfaceContainerLow => "#1A1F1A";
    public string SurfaceContainer => "#242924";
    public string SurfaceContainerHigh => "#2F342E";
    public string SurfaceContainerHighest => "#3A3F39";
}
