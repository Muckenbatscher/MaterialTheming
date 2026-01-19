namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#C0C7D5";
    public string OnPrimary => "#3A404C";
    public string PrimaryContainer => "#404753";
    public string OnPrimaryContainer => "#CAD0DF";
    // Secondary
    public string Secondary => "#9C9EA4";
    public string OnSecondary => "#1E2025";
    public string SecondaryContainer => "#393B41";
    public string OnSecondaryContainer => "#BEBFC5";
    // Tertiary
    public string Tertiary => "#EBE9FF";
    public string OnTertiary => "#54546F";
    public string TertiaryContainer => "#DBDAFB";
    public string OnTertiaryContainer => "#4B4C67";
    // Error
    public string Error => "#EE7D77";
    public string OnError => "#490106";
    public string ErrorContainer => "#7F2927";
    public string OnErrorContainer => "#FF9993";
    // Surface
    public string Surface => "#0E0E0F";
    public string SurfaceVariant => "#252628";
    public string OnSurface => "#E6E5E7";
    public string OnSurfaceVariant => "#ABAAAD";
    public string SurfaceDim => "#0E0E0F";
    public string SurfaceBright => "#2B2C2F";
    public string SurfaceTint => "#C0C7D5";
    // Background
    public string Background => "#0E0E0F";
    public string OnBackground => "#E6E5E7";
    // Outline
    public string Outline => "#757578";
    public string OutlineVariant => "#47484A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FCF8F9";
    public string InverseOnSurface => "#565555";
    public string InversePrimary => "#595F6C";
    // Primary Fixed
    public string PrimaryFixed => "#DCE2F2";
    public string OnPrimaryFixed => "#39404B";
    public string PrimaryFixedDim => "#CED4E3";
    public string OnPrimaryFixedVariant => "#555C68";
    // Secondary Fixed
    public string SecondaryFixed => "#E1E2E9";
    public string OnSecondaryFixed => "#3D3F45";
    public string SecondaryFixedDim => "#D3D4DA";
    public string OnSecondaryFixedVariant => "#595B61";
    // Tertiary Fixed
    public string TertiaryFixed => "#DBDAFB";
    public string OnTertiaryFixed => "#393A53";
    public string TertiaryFixedDim => "#CDCCEC";
    public string OnTertiaryFixedVariant => "#555671";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#131314";
    public string SurfaceContainer => "#19191B";
    public string SurfaceContainerHigh => "#1F1F21";
    public string SurfaceContainerHighest => "#252628";
}
