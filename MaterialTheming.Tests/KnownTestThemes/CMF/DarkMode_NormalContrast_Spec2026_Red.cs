namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_NormalContrast_Spec2026_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FF7165";
    public string OnPrimary => "#4A0003";
    public string PrimaryContainer => "#CF443B";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#DA887F";
    public string OnSecondary => "#400E0B";
    public string SecondaryContainer => "#561E1A";
    public string OnSecondaryContainer => "#EF9A91";
    // Tertiary
    public string Tertiary => "#F17B6F";
    public string OnTertiary => "#4A0003";
    public string TertiaryContainer => "#BD534A";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#FF7169";
    public string OnError => "#490004";
    public string ErrorContainer => "#7D000D";
    public string OnErrorContainer => "#FFA9A2";
    // Surface
    public string Surface => "#1B0907";
    public string SurfaceVariant => "#3F1B17";
    public string OnSurface => "#FFDEDA";
    public string OnSurfaceVariant => "#D79D96";
    public string SurfaceDim => "#1B0907";
    public string SurfaceBright => "#47211D";
    public string SurfaceTint => "#FF7165";
    // Background
    public string Background => "#1B0907";
    public string OnBackground => "#FFDEDA";
    // Outline
    public string Outline => "#9C6862";
    public string OutlineVariant => "#683C37";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F7";
    public string InverseOnSurface => "#6A4E4B";
    public string InversePrimary => "#B12E28";
    // Primary Fixed
    public string PrimaryFixed => "#CF443B";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#BD3730";
    public string OnPrimaryFixedVariant => "#FFE2DE";
    // Secondary Fixed
    public string SecondaryFixed => "#FCA59B";
    public string OnSecondaryFixed => "#44110E";
    public string SecondaryFixedDim => "#EC988E";
    public string OnSecondaryFixedVariant => "#6B2F29";
    // Tertiary Fixed
    public string TertiaryFixed => "#BD534A";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#AD473F";
    public string OnTertiaryFixedVariant => "#FFE2DE";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#240C0A";
    public string SurfaceContainer => "#2D110F";
    public string SurfaceContainerHigh => "#351613";
    public string SurfaceContainerHighest => "#3F1B17";
}
