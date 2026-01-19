namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_HighContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFEDE0";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#FFB26E";
    public string OnPrimaryContainer => "#160800";
    // Secondary
    public string Secondary => "#FFEDE0";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#FBB375";
    public string OnSecondaryContainer => "#160800";
    // Tertiary
    public string Tertiary => "#F7F49A";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#C9C772";
    public string OnTertiaryContainer => "#0C0C00";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#141407";
    public string SurfaceVariant => "#49482D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#141407";
    public string SurfaceBright => "#525140";
    public string SurfaceTint => "#FFB779";
    // Background
    public string Background => "#141407";
    public string OnBackground => "#E6E3CD";
    // Outline
    public string Outline => "#F5F2CC";
    public string OutlineVariant => "#C7C4A1";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E6E3CD";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#6E3B00";
    // Primary Fixed
    public string PrimaryFixed => "#FFDCC1";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FFB779";
    public string OnPrimaryFixedVariant => "#1F0C00";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDCC1";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#FFB779";
    public string OnSecondaryFixedVariant => "#1F0C00";
    // Tertiary Fixed
    public string TertiaryFixed => "#E9E78E";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#CDCA75";
    public string OnTertiaryFixedVariant => "#121200";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#212012";
    public string SurfaceContainer => "#323122";
    public string SurfaceContainerHigh => "#3D3C2C";
    public string SurfaceContainerHighest => "#484737";
}
