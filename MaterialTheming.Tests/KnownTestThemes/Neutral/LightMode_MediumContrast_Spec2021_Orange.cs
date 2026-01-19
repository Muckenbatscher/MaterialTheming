namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#453227";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#80685B";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#41332C";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#7A6A61";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#493121";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#856655";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F5";
    public string SurfaceVariant => "#E9E1DE";
    public string OnSurface => "#13110F";
    public string OnSurfaceVariant => "#393534";
    public string SurfaceDim => "#CCC5C2";
    public string SurfaceBright => "#FFF8F5";
    public string SurfaceTint => "#705A4D";
    // Background
    public string Background => "#FFF8F5";
    public string OnBackground => "#1E1B19";
    // Outline
    public string Outline => "#56514F";
    public string OutlineVariant => "#716C6A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#33302E";
    public string InverseOnSurface => "#F7EFEC";
    public string InversePrimary => "#DEC1B1";
    // Primary Fixed
    public string PrimaryFixed => "#80685B";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#665044";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#7A6A61";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#61524A";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#856655";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#6B4F3E";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FAF2EF";
    public string SurfaceContainer => "#EEE6E4";
    public string SurfaceContainerHigh => "#E3DBD8";
    public string SurfaceContainerHighest => "#D8D0CD";
}
