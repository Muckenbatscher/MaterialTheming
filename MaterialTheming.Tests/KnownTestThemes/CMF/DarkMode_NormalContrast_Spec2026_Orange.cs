namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_NormalContrast_Spec2026_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#E78543";
    public string OnPrimary => "#391600";
    public string PrimaryContainer => "#E78543";
    public string OnPrimaryContainer => "#391600";
    // Secondary
    public string Secondary => "#C89273";
    public string OnSecondary => "#371703";
    public string SecondaryContainer => "#4B270F";
    public string OnSecondaryContainer => "#DCA484";
    // Tertiary
    public string Tertiary => "#D88C5B";
    public string OnTertiary => "#391600";
    public string TertiaryContainer => "#D88C5B";
    public string OnTertiaryContainer => "#391600";
    // Error
    public string Error => "#F8847C";
    public string OnError => "#54080A";
    public string ErrorContainer => "#480004";
    public string OnErrorContainer => "#EE7C75";
    // Surface
    public string Surface => "#170B05";
    public string SurfaceVariant => "#382011";
    public string OnSurface => "#FFDFCE";
    public string OnSurfaceVariant => "#CAA38D";
    public string SurfaceDim => "#170B05";
    public string SurfaceBright => "#3F2617";
    public string SurfaceTint => "#E78543";
    // Background
    public string Background => "#170B05";
    public string OnBackground => "#FFDFCE";
    // Outline
    public string Outline => "#906E5B";
    public string OutlineVariant => "#5E4230";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F5";
    public string InverseOnSurface => "#645147";
    public string InversePrimary => "#994805";
    // Primary Fixed
    public string PrimaryFixed => "#E78543";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#D77837";
    public string OnPrimaryFixedVariant => "#481E00";
    // Secondary Fixed
    public string SecondaryFixed => "#FABF9D";
    public string OnSecondaryFixed => "#4B270F";
    public string SecondaryFixedDim => "#EBB290";
    public string OnSecondaryFixedVariant => "#6C4329";
    // Tertiary Fixed
    public string TertiaryFixed => "#D88C5B";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#C97F50";
    public string OnTertiaryFixedVariant => "#481E00";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1F1006";
    public string SurfaceContainer => "#27150A";
    public string SurfaceContainerHigh => "#2F1B0E";
    public string SurfaceContainerHighest => "#382011";
}
