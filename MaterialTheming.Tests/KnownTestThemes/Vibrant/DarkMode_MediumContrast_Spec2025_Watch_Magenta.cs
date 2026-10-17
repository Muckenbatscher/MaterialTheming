namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2025_Watch_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#C26898";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFEFF";
    public string OnSecondary => "#1C0029";
    public string SecondaryContainer => "#A077AE";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#A295EF";
    public string OnTertiaryContainer => "#130050";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3D000F";
    public string ErrorContainer => "#CC6674";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#341D3C";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#E0C6E4";
    public string SurfaceDim => "#17081D";
    public string SurfaceBright => "#3B2244";
    public string SurfaceTint => "#FFFEFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#B69EBA";
    public string OutlineVariant => "#957E9A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF7FB";
    public string InverseOnSurface => "#443249";
    public string InversePrimary => "#651A48";
    // Primary Fixed
    public string PrimaryFixed => "#FFBCDB";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FD99CD";
    public string OnPrimaryFixedVariant => "#560B3B";
    // Secondary Fixed
    public string SecondaryFixed => "#F1C1FE";
    public string OnSecondaryFixed => "#1C0029";
    public string SecondaryFixedDim => "#E2B4EF";
    public string OnSecondaryFixedVariant => "#492557";
    // Tertiary Fixed
    public string TertiaryFixed => "#D1C8FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#B0A2FD";
    public string OnTertiaryFixedVariant => "#220F68";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#301F36";
    public string SurfaceContainer => "#3C2A41";
    public string SurfaceContainerHigh => "#47354D";
    public string SurfaceContainerHighest => "#341D3C";
}
