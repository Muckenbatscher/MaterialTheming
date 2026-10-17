namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2025_Watch_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFBCDB";
    public string OnPrimary => "#571C3F";
    public string PrimaryContainer => "#703054";
    public string OnPrimaryContainer => "#FFD5E7";
    // Secondary
    public string Secondary => "#BBECE9";
    public string OnSecondary => "#154645";
    public string SecondaryContainer => "#1E4E4C";
    public string OnSecondaryContainer => "#B9E9E6";
    // Tertiary
    public string Tertiary => "#77FDF2";
    public string OnTertiary => "#004C47";
    public string TertiaryContainer => "#57E0D6";
    public string OnTertiaryContainer => "#00423E";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3F000F";
    public string ErrorContainer => "#7D2938";
    public string OnErrorContainer => "#FFD6D9";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#371E2B";
    public string OnSurface => "#FCE1EB";
    public string OnSurfaceVariant => "#E2C7D1";
    public string SurfaceDim => "#170A11";
    public string SurfaceBright => "#402332";
    public string SurfaceTint => "#FFBCDB";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#B89FA9";
    public string OutlineVariant => "#968089";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F8";
    public string InverseOnSurface => "#635058";
    public string InversePrimary => "#813F63";
    // Primary Fixed
    public string PrimaryFixed => "#FFBCDB";
    public string OnPrimaryFixed => "#571C3F";
    public string PrimaryFixedDim => "#FCA8D1";
    public string OnPrimaryFixedVariant => "#703054";
    // Secondary Fixed
    public string SecondaryFixed => "#BBECE9";
    public string OnSecondaryFixed => "#154645";
    public string SecondaryFixedDim => "#AEDDDB";
    public string OnSecondaryFixedVariant => "#1E4E4C";
    // Tertiary Fixed
    public string TertiaryFixed => "#77FDF2";
    public string OnTertiaryFixed => "#004C47";
    public string TertiaryFixedDim => "#67EFE4";
    public string OnTertiaryFixedVariant => "#00504B";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#312129";
    public string SurfaceContainer => "#3D2C33";
    public string SurfaceContainerHigh => "#48363E";
    public string SurfaceContainerHighest => "#371E2B";
}
