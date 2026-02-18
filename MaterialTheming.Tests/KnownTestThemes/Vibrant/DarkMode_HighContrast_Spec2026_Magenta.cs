namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2026_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFDCEA";
    public string OnPrimary => "#5A003D";
    public string PrimaryContainer => "#FF71C2";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFDBF4";
    public string OnSecondary => "#540052";
    public string SecondaryContainer => "#E282D5";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#E2E4FF";
    public string OnTertiary => "#001D82";
    public string TertiaryContainer => "#8B9DFF";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFDDDF";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#FF798C";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#1F031D";
    public string SurfaceVariant => "#40143C";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFDBF4";
    public string SurfaceDim => "#1F031D";
    public string SurfaceBright => "#491945";
    public string SurfaceTint => "#FFDCEA";
    // Background
    public string Background => "#1F031D";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#DAAACF";
    public string OutlineVariant => "#C496B9";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF7F9";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#70004D";
    // Primary Fixed
    public string PrimaryFixed => "#FF71C2";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#F45EB6";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#FFBDF1";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#FFA6F0";
    public string OnSecondaryFixedVariant => "#20001F";
    // Tertiary Fixed
    public string TertiaryFixed => "#9DABFF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#8A9DFF";
    public string OnTertiaryFixedVariant => "#000000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#270524";
    public string SurfaceContainer => "#2F0A2C";
    public string SurfaceContainerHigh => "#380E34";
    public string SurfaceContainerHighest => "#40143C";
}
