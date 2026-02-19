namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2026_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#F6BA96";
    public string OnPrimary => "#522C13";
    public string PrimaryContainer => "#9B694B";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#E5BFA9";
    public string OnSecondary => "#493121";
    public string SecondaryContainer => "#8E6E5C";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#FFF6DE";
    public string OnTertiary => "#5F531C";
    public string TertiaryContainer => "#FAE8A2";
    public string OnTertiaryContainer => "#574B15";
    // Error
    public string Error => "#FFA089";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#C44F34";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#130D09";
    public string SurfaceVariant => "#30231C";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#CAB5AA";
    public string SurfaceDim => "#130D09";
    public string SurfaceBright => "#362922";
    public string SurfaceTint => "#F6BA96";
    // Background
    public string Background => "#130D09";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#A39085";
    public string OutlineVariant => "#847268";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F5";
    public string InverseOnSurface => "#3F3632";
    public string InversePrimary => "#774B2F";
    // Primary Fixed
    public string PrimaryFixed => "#FCBF9B";
    public string OnPrimaryFixed => "#090200";
    public string PrimaryFixedDim => "#EDB18F";
    public string OnPrimaryFixedVariant => "#4B270E";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDBC8";
    public string OnSecondaryFixed => "#301A0D";
    public string SecondaryFixedDim => "#F4CCB7";
    public string OnSecondaryFixedVariant => "#533A2A";
    // Tertiary Fixed
    public string TertiaryFixed => "#FAE8A2";
    public string OnTertiaryFixed => "#2B2300";
    public string TertiaryFixedDim => "#ECDA95";
    public string OnTertiaryFixedVariant => "#4E420C";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1A120D";
    public string SurfaceContainer => "#211812";
    public string SurfaceContainerHigh => "#281D17";
    public string SurfaceContainerHighest => "#30231C";
}
