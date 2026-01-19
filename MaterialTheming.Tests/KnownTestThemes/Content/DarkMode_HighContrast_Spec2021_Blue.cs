namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_HighContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#EAF0FF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#9FC4FF";
    public string OnPrimaryContainer => "#000B1E";
    // Secondary
    public string Secondary => "#EAF0FF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#B0C4E7";
    public string OnSecondaryContainer => "#000B1E";
    // Tertiary
    public string Tertiary => "#FFEAFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#ECABFF";
    public string OnTertiaryContainer => "#190024";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#111318";
    public string SurfaceVariant => "#424751";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#111318";
    public string SurfaceBright => "#4E5056";
    public string SurfaceTint => "#A6C8FF";
    // Background
    public string Background => "#111318";
    public string OnBackground => "#E1E2E9";
    // Outline
    public string Outline => "#EBF0FD";
    public string OutlineVariant => "#BEC3CF";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E1E2E9";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#004889";
    // Primary Fixed
    public string PrimaryFixed => "#D5E3FF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#A6C8FF";
    public string OnPrimaryFixedVariant => "#001128";
    // Secondary Fixed
    public string SecondaryFixed => "#D5E3FF";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#B3C7EB";
    public string OnSecondaryFixedVariant => "#001128";
    // Tertiary Fixed
    public string TertiaryFixed => "#FAD7FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#EEB0FF";
    public string OnTertiaryFixedVariant => "#230030";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1D2025";
    public string SurfaceContainer => "#2E3036";
    public string SurfaceContainerHigh => "#393B41";
    public string SurfaceContainerHighest => "#44474C";
}
