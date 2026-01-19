namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#F4F1D5";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#C6C4A9";
    public string OnPrimaryContainer => "#0C0C01";
    // Secondary
    public string Secondary => "#F4F0DE";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#C6C3B2";
    public string OnSecondaryContainer => "#0C0C04";
    // Tertiary
    public string Tertiary => "#F5F2CC";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#C7C4A1";
    public string OnTertiaryContainer => "#0C0C00";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#141311";
    public string SurfaceVariant => "#484744";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#141311";
    public string SurfaceBright => "#51504D";
    public string SurfaceTint => "#CAC7AD";
    // Background
    public string Background => "#141311";
    public string OnBackground => "#E6E2DD";
    // Outline
    public string Outline => "#F3EFEB";
    public string OutlineVariant => "#C5C2BE";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E6E2DD";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#4A4935";
    // Primary Fixed
    public string PrimaryFixed => "#E7E3C8";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#CAC7AD";
    public string OnPrimaryFixedVariant => "#121204";
    // Secondary Fixed
    public string SecondaryFixed => "#E6E3D1";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#CAC7B6";
    public string OnSecondaryFixedVariant => "#121208";
    // Tertiary Fixed
    public string TertiaryFixed => "#E7E4BF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#CBC8A4";
    public string OnTertiaryFixedVariant => "#121201";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#20201D";
    public string SurfaceContainer => "#31302D";
    public string SurfaceContainerHigh => "#3C3B38";
    public string SurfaceContainerHighest => "#484744";
}
