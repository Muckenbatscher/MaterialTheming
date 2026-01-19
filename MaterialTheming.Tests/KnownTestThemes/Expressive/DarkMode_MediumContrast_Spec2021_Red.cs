namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#CEDCFF";
    public string OnPrimary => "#002453";
    public string PrimaryContainer => "#7191CE";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#DAE1AB";
    public string OnSecondary => "#232804";
    public string SecondaryContainer => "#8E9565";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#BDE8B2";
    public string OnTertiary => "#072C09";
    public string TertiaryContainer => "#739B6C";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#1C110D";
    public string SurfaceVariant => "#58423A";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F6D5CA";
    public string SurfaceDim => "#1C110D";
    public string SurfaceBright => "#50413C";
    public string SurfaceTint => "#ACC7FF";
    // Background
    public string Background => "#1C110D";
    public string OnBackground => "#F5DED6";
    // Outline
    public string Outline => "#CAABA1";
    public string OutlineVariant => "#A68A80";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F5DED6";
    public string InverseOnSurface => "#342722";
    public string InversePrimary => "#244780";
    // Primary Fixed
    public string PrimaryFixed => "#D7E2FF";
    public string OnPrimaryFixed => "#00102C";
    public string PrimaryFixedDim => "#ACC7FF";
    public string OnPrimaryFixedVariant => "#0A356D";
    // Secondary Fixed
    public string SecondaryFixed => "#E0E7B1";
    public string OnSecondaryFixed => "#0F1300";
    public string SecondaryFixedDim => "#C4CB97";
    public string OnSecondaryFixedVariant => "#333913";
    // Tertiary Fixed
    public string TertiaryFixed => "#C3EEB8";
    public string OnTertiaryFixed => "#001601";
    public string TertiaryFixedDim => "#A7D29E";
    public string OnTertiaryFixedVariant => "#1A3E18";
    // Surface Container
    public string SurfaceContainerLowest => "#0E0603";
    public string SurfaceContainerLow => "#271B16";
    public string SurfaceContainer => "#322520";
    public string SurfaceContainerHigh => "#3D302B";
    public string SurfaceContainerHighest => "#493A35";
}
