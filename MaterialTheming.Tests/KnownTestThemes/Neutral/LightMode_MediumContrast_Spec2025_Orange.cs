namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#4E4038";
    public string OnPrimary => "#EBD5CB";
    public string PrimaryContainer => "#827168";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#49413E";
    public string OnSecondary => "#E3D7D2";
    public string SecondaryContainer => "#7C736E";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#543F1F";
    public string OnTertiary => "#F5D5A9";
    public string TertiaryContainer => "#8A704C";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#792713";
    public string OnError => "#FFCFC4";
    public string ErrorContainer => "#BA573F";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F6";
    public string SurfaceVariant => "#EBE0DC";
    public string OnSurface => "#282320";
    public string OnSurfaceVariant => "#48423F";
    public string SurfaceDim => "#E3D8D3";
    public string SurfaceBright => "#FFF8F6";
    public string SurfaceTint => "#4E4038";
    // Background
    public string Background => "#FFF8F6";
    public string OnBackground => "#282320";
    // Outline
    public string Outline => "#645E5A";
    public string OutlineVariant => "#817976";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#100E0D";
    public string InverseOnSurface => "#C9C3C1";
    public string InversePrimary => "#FDE7DC";
    // Primary Fixed
    public string PrimaryFixed => "#827168";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#75655C";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#7C736E";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#6F6662";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#8A704C";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#7D6440";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FAF2EF";
    public string SurfaceContainer => "#F5ECE9";
    public string SurfaceContainerHigh => "#F0E6E2";
    public string SurfaceContainerHighest => "#EBE0DC";
}
