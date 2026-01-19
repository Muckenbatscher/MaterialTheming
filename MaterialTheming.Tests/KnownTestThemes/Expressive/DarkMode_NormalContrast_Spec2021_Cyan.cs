namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#E7C361";
    public string OnPrimary => "#3D2E00";
    public string PrimaryContainer => "#584400";
    public string OnPrimaryContainer => "#FFDF90";
    // Secondary
    public string Secondary => "#CEC0E8";
    public string OnSecondary => "#352B4B";
    public string SecondaryContainer => "#4C4163";
    public string OnSecondaryContainer => "#EADDFF";
    // Tertiary
    public string Tertiary => "#93CFE8";
    public string OnTertiary => "#003544";
    public string TertiaryContainer => "#004D62";
    public string OnTertiaryContainer => "#BAEAFF";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#0D1418";
    public string SurfaceVariant => "#3B494F";
    public string OnSurface => "#DCE4E8";
    public string OnSurfaceVariant => "#BAC9D0";
    public string SurfaceDim => "#0D1418";
    public string SurfaceBright => "#323A3E";
    public string SurfaceTint => "#E7C361";
    // Background
    public string Background => "#0D1418";
    public string OnBackground => "#DCE4E8";
    // Outline
    public string Outline => "#84939A";
    public string OutlineVariant => "#3B494F";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#DCE4E8";
    public string InverseOnSurface => "#2A3235";
    public string InversePrimary => "#755B00";
    // Primary Fixed
    public string PrimaryFixed => "#FFDF90";
    public string OnPrimaryFixed => "#241A00";
    public string PrimaryFixedDim => "#E7C361";
    public string OnPrimaryFixedVariant => "#584400";
    // Secondary Fixed
    public string SecondaryFixed => "#EADDFF";
    public string OnSecondaryFixed => "#1F1635";
    public string SecondaryFixedDim => "#CEC0E8";
    public string OnSecondaryFixedVariant => "#4C4163";
    // Tertiary Fixed
    public string TertiaryFixed => "#BAEAFF";
    public string OnTertiaryFixed => "#001F29";
    public string TertiaryFixedDim => "#93CFE8";
    public string OnTertiaryFixedVariant => "#004D62";
    // Surface Container
    public string SurfaceContainerLowest => "#080F13";
    public string SurfaceContainerLow => "#151D20";
    public string SurfaceContainer => "#192124";
    public string SurfaceContainerHigh => "#232B2F";
    public string SurfaceContainerHighest => "#2E363A";
}
