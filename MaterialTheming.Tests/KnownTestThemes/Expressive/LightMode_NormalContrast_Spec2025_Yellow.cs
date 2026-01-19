namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#3E3D00";
    public string OnPrimary => "#C6C44F";
    public string PrimaryContainer => "#EAE86E";
    public string OnPrimaryContainer => "#565400";
    // Secondary
    public string Secondary => "#566483";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#D7E2FF";
    public string OnSecondaryContainer => "#435270";
    // Tertiary
    public string Tertiary => "#4061AF";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#9DB7FF";
    public string OnTertiaryContainer => "#01327E";
    // Error
    public string Error => "#B23D21";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FA7150";
    public string OnErrorContainer => "#671200";
    // Surface
    public string Surface => "#FFFBFF";
    public string SurfaceVariant => "#EFED85";
    public string OnSurface => "#3B3A00";
    public string OnSurfaceVariant => "#69670A";
    public string SurfaceDim => "#EAE86D";
    public string SurfaceBright => "#FFFBFF";
    public string SurfaceTint => "#3E3D00";
    // Background
    public string Background => "#FFFBFF";
    public string OnBackground => "#3B3A00";
    // Outline
    public string Outline => "#868429";
    public string OutlineVariant => "#C0BE5C";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0F0F00";
    public string InverseOnSurface => "#A19F79";
    public string InversePrimary => "#F0EE73";
    // Primary Fixed
    public string PrimaryFixed => "#EAE86E";
    public string OnPrimaryFixed => "#424100";
    public string PrimaryFixedDim => "#DCDA62";
    public string OnPrimaryFixedVariant => "#605E00";
    // Secondary Fixed
    public string SecondaryFixed => "#D7E2FF";
    public string OnSecondaryFixed => "#313F5C";
    public string SecondaryFixedDim => "#C5D4F8";
    public string OnSecondaryFixedVariant => "#4D5C7A";
    // Tertiary Fixed
    public string TertiaryFixed => "#9DB7FF";
    public string OnTertiaryFixed => "#001D51";
    public string TertiaryFixedDim => "#89A9FC";
    public string OnTertiaryFixedVariant => "#133B88";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFFCC6";
    public string SurfaceContainer => "#FAF7B0";
    public string SurfaceContainerHigh => "#F5F29B";
    public string SurfaceContainerHighest => "#EFED85";
}
