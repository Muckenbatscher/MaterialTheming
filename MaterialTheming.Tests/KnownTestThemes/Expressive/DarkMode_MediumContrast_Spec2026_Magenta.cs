namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2026_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#F9ADD2";
    public string OnPrimary => "#56213F";
    public string PrimaryContainer => "#A16082";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#B0CCC8";
    public string OnSecondary => "#223B38";
    public string SecondaryContainer => "#607A76";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#89FFED";
    public string OnTertiary => "#00574E";
    public string TertiaryContainer => "#6EF2DF";
    public string OnTertiaryContainer => "#004E46";
    // Error
    public string Error => "#FF9DA8";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#C8475D";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#190911";
    public string SurfaceVariant => "#3A1C2C";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DAACC1";
    public string SurfaceDim => "#190911";
    public string SurfaceBright => "#432133";
    public string SurfaceTint => "#F9ADD2";
    // Background
    public string Background => "#190911";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#B2879B";
    public string OutlineVariant => "#926A7D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F8";
    public string InverseOnSurface => "#47323C";
    public string InversePrimary => "#7D4161";
    // Primary Fixed
    public string PrimaryFixed => "#F9ADD2";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#EAA0C4";
    public string OnPrimaryFixedVariant => "#4A1735";
    // Secondary Fixed
    public string SecondaryFixed => "#DAF7F2";
    public string OnSecondaryFixed => "#152E2C";
    public string SecondaryFixedDim => "#CCE8E4";
    public string OnSecondaryFixedVariant => "#334D4A";
    // Tertiary Fixed
    public string TertiaryFixed => "#6EF2DF";
    public string OnTertiaryFixed => "#001F1B";
    public string TertiaryFixedDim => "#5EE3D1";
    public string OnTertiaryFixedVariant => "#00443D";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#200D17";
    public string SurfaceContainer => "#29121E";
    public string SurfaceContainerHigh => "#311725";
    public string SurfaceContainerHighest => "#3A1C2C";
}
