namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#D7C2B8";
    public string OnPrimary => "#4B3D36";
    public string PrimaryContainer => "#52443C";
    public string OnPrimaryContainer => "#E1CCC2";
    // Secondary
    public string Secondary => "#A69C97";
    public string OnSecondary => "#251F1C";
    public string SecondaryContainer => "#413A36";
    public string OnSecondaryContainer => "#C8BDB8";
    // Tertiary
    public string Tertiary => "#FFEEDB";
    public string OnTertiary => "#6E5634";
    public string TertiaryContainer => "#FFDDB1";
    public string OnTertiaryContainer => "#654E2C";
    // Error
    public string Error => "#ED7F64";
    public string OnError => "#450900";
    public string ErrorContainer => "#7E2B17";
    public string OnErrorContainer => "#FF9B82";
    // Surface
    public string Surface => "#100E0D";
    public string SurfaceVariant => "#2A2522";
    public string OnSurface => "#EEE3DF";
    public string OnSurfaceVariant => "#B2A9A5";
    public string SurfaceDim => "#100E0D";
    public string SurfaceBright => "#312B28";
    public string SurfaceTint => "#D7C2B8";
    // Background
    public string Background => "#100E0D";
    public string OnBackground => "#EEE3DF";
    // Outline
    public string Outline => "#7B7470";
    public string OutlineVariant => "#4D4744";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F6";
    public string InverseOnSurface => "#585453";
    public string InversePrimary => "#6B5C53";
    // Primary Fixed
    public string PrimaryFixed => "#F4DED3";
    public string OnPrimaryFixed => "#4A3C35";
    public string PrimaryFixedDim => "#E5D0C6";
    public string OnPrimaryFixedVariant => "#685850";
    // Secondary Fixed
    public string SecondaryFixed => "#ECE0DB";
    public string OnSecondaryFixed => "#453E3A";
    public string SecondaryFixedDim => "#DED2CD";
    public string OnSecondaryFixedVariant => "#625A56";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDDB1";
    public string OnTertiaryFixed => "#513C1C";
    public string TertiaryFixedDim => "#F0CFA4";
    public string OnTertiaryFixedVariant => "#6F5835";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#151311";
    public string SurfaceContainer => "#1C1917";
    public string SurfaceContainerHigh => "#231F1D";
    public string SurfaceContainerHighest => "#2A2522";
}
