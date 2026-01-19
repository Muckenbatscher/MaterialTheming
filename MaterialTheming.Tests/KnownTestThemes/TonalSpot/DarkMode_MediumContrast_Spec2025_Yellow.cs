namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#CCC98D";
    public string OnPrimary => "#39380A";
    public string PrimaryContainer => "#787743";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#CBC8A4";
    public string OnSecondary => "#38371D";
    public string SecondaryContainer => "#777657";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#FFE4C0";
    public string OnTertiary => "#624614";
    public string TertiaryContainer => "#FED494";
    public string OnTertiaryContainer => "#593E0C";
    // Error
    public string Error => "#FFA089";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#C44F34";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#0F0E08";
    public string SurfaceVariant => "#27261A";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#BCB9A7";
    public string SurfaceDim => "#0F0E08";
    public string SurfaceBright => "#2D2D20";
    public string SurfaceTint => "#CCC98D";
    // Background
    public string Background => "#0F0E08";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#969483";
    public string OutlineVariant => "#787666";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FDF9EE";
    public string InverseOnSurface => "#393831";
    public string InversePrimary => "#585727";
    // Primary Fixed
    public string PrimaryFixed => "#E8E6A7";
    public string OnPrimaryFixed => "#212100";
    public string PrimaryFixedDim => "#DAD79A";
    public string OnPrimaryFixedVariant => "#424113";
    // Secondary Fixed
    public string SecondaryFixed => "#E7E4BF";
    public string OnSecondaryFixed => "#212009";
    public string SecondaryFixedDim => "#D9D6B1";
    public string OnSecondaryFixedVariant => "#414126";
    // Tertiary Fixed
    public string TertiaryFixed => "#FED494";
    public string OnTertiaryFixed => "#231500";
    public string TertiaryFixedDim => "#EFC688";
    public string OnTertiaryFixedVariant => "#4F3503";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#14140C";
    public string SurfaceContainer => "#1A1A11";
    public string SurfaceContainerHigh => "#212016";
    public string SurfaceContainerHighest => "#27261A";
}
