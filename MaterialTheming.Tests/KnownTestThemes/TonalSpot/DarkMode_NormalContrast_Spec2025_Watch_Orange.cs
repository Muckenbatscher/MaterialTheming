namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2025_Watch_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFC29E";
    public string OnPrimary => "#522606";
    public string PrimaryContainer => "#6B3A18";
    public string OnPrimaryContainer => "#FFD8C3";
    // Secondary
    public string Secondary => "#FDD5BF";
    public string OnSecondary => "#4F3627";
    public string SecondaryContainer => "#5C4131";
    public string OnSecondaryContainer => "#FFD8C3";
    // Tertiary
    public string Tertiary => "#FED489";
    public string OnTertiary => "#4D3600";
    public string TertiaryContainer => "#E0B870";
    public string OnTertiaryContainer => "#412D00";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#3B0600";
    public string ErrorContainer => "#7D2C19";
    public string OnErrorContainer => "#FFD7CE";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#382011";
    public string OnSurface => "#FDE3D5";
    public string OnSurfaceVariant => "#E2C9BC";
    public string SurfaceDim => "#170B05";
    public string SurfaceBright => "#3F2617";
    public string SurfaceTint => "#FFC29E";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#B8A195";
    public string OutlineVariant => "#978176";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F5";
    public string InverseOnSurface => "#645147";
    public string InversePrimary => "#7D4825";
    // Primary Fixed
    public string PrimaryFixed => "#FFC29E";
    public string OnPrimaryFixed => "#522606";
    public string PrimaryFixedDim => "#F9B186";
    public string OnPrimaryFixedVariant => "#6B3A18";
    // Secondary Fixed
    public string SecondaryFixed => "#FDD5BF";
    public string OnSecondaryFixed => "#4F3627";
    public string SecondaryFixedDim => "#EEC7B1";
    public string OnSecondaryFixedVariant => "#5C4131";
    // Tertiary Fixed
    public string TertiaryFixed => "#FED489";
    public string OnTertiaryFixed => "#4D3600";
    public string TertiaryFixedDim => "#EFC67C";
    public string OnTertiaryFixedVariant => "#5D4202";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#31231A";
    public string SurfaceContainer => "#3D2D24";
    public string SurfaceContainerHigh => "#48382E";
    public string SurfaceContainerHighest => "#382011";
}
