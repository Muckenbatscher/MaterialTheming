namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#1F261E";
    public string OnPrimary => "#D5DCD1";
    public string PrimaryContainer => "#4D544C";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#222521";
    public string OnSecondary => "#D9DBD5";
    public string SecondaryContainer => "#50534F";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#0E291A";
    public string OnTertiary => "#C2E2CA";
    public string TertiaryContainer => "#3D5846";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#4C0A00";
    public string OnError => "#FFCFC4";
    public string ErrorContainer => "#8D3621";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FBF9F6";
    public string SurfaceVariant => "#E3E3DE";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#232422";
    public string SurfaceDim => "#DADAD5";
    public string SurfaceBright => "#FBF9F6";
    public string SurfaceTint => "#1F261E";
    // Background
    public string Background => "#FBF9F6";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#424340";
    public string OutlineVariant => "#51534F";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0E0E0D";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#F4FCF0";
    // Primary Fixed
    public string PrimaryFixed => "#4D544C";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#414840";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#50534F";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#454743";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#3D5846";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#314C3B";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F5F3F0";
    public string SurfaceContainer => "#EFEEEA";
    public string SurfaceContainerHigh => "#E9E8E4";
    public string SurfaceContainerHighest => "#E3E3DE";
}
