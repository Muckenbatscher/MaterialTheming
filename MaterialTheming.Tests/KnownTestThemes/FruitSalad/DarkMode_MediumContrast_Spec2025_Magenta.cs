namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_MediumContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#E4D6FF";
    public string OnPrimary => "#2E0F67";
    public string PrimaryContainer => "#9C82DA";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#E4D6FF";
    public string OnSecondary => "#2B1B51";
    public string SecondaryContainer => "#9987C5";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFCFE4";
    public string OnTertiary => "#451230";
    public string TertiaryContainer => "#C17C9E";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#1C1016";
    public string SurfaceVariant => "#58404B";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F6D3E1";
    public string SurfaceDim => "#1C1016";
    public string SurfaceBright => "#504047";
    public string SurfaceTint => "#D0BCFF";
    // Background
    public string Background => "#1C1016";
    public string OnBackground => "#F4DDE5";
    // Outline
    public string Outline => "#CAA9B7";
    public string OutlineVariant => "#A78895";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F4DDE5";
    public string InverseOnSurface => "#34262C";
    public string InversePrimary => "#51388B";
    // Primary Fixed
    public string PrimaryFixed => "#E9DDFF";
    public string OnPrimaryFixed => "#170041";
    public string PrimaryFixedDim => "#D0BCFF";
    public string OnPrimaryFixedVariant => "#3F2578";
    // Secondary Fixed
    public string SecondaryFixed => "#E9DDFF";
    public string OnSecondaryFixed => "#16033C";
    public string SecondaryFixedDim => "#D0BCFE";
    public string OnSecondaryFixedVariant => "#3C2C63";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFD8E8";
    public string OnTertiaryFixed => "#2A001A";
    public string TertiaryFixedDim => "#FCB0D5";
    public string OnTertiaryFixedVariant => "#592341";
    // Surface Container
    public string SurfaceContainerLowest => "#0E0509";
    public string SurfaceContainerLow => "#271A20";
    public string SurfaceContainer => "#32242A";
    public string SurfaceContainerHigh => "#3D2F35";
    public string SurfaceContainerHighest => "#493A40";
}
