namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class LightMode_NormalContrast_Spec2026_Cyan_Red : ITestThemeSecondSourceColor
{
    public string SourceColor => "#00BCD1"; //Cyan
    public string SecondSourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#006975";
    public string OnPrimary => "#ECFCFF";
    public string PrimaryContainer => "#00BCD1";
    public string OnPrimaryContainer => "#003138";
    // Secondary
    public string Secondary => "#38666E";
    public string OnSecondary => "#ECFCFF";
    public string SecondaryContainer => "#BBEBF4";
    public string OnSecondaryContainer => "#295860";
    // Tertiary
    public string Tertiary => "#B12E28";
    public string OnTertiary => "#FFF7F6";
    public string TertiaryContainer => "#CF443B";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#9F3F47";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#FA868D";
    public string OnErrorContainer => "#580817";
    // Surface
    public string Surface => "#EEFCFF";
    public string SurfaceVariant => "#CBE8ED";
    public string OnSurface => "#1C363B";
    public string OnSurfaceVariant => "#496368";
    public string SurfaceDim => "#C3DFE5";
    public string SurfaceBright => "#EEFCFF";
    public string SurfaceTint => "#006975";
    // Background
    public string Background => "#EEFCFF";
    public string OnBackground => "#1C363B";
    // Outline
    public string Outline => "#657F84";
    public string OutlineVariant => "#9BB7BC";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#001114";
    public string InverseOnSurface => "#929FA2";
    public string InversePrimary => "#54E4F9";
    // Primary Fixed
    public string PrimaryFixed => "#00BCD1";
    public string OnPrimaryFixed => "#001316";
    public string PrimaryFixedDim => "#00ADC1";
    public string OnPrimaryFixedVariant => "#003B43";
    // Secondary Fixed
    public string SecondaryFixed => "#BBEBF4";
    public string OnSecondaryFixed => "#13464D";
    public string SecondaryFixedDim => "#ADDCE6";
    public string OnSecondaryFixedVariant => "#34626A";
    // Tertiary Fixed
    public string TertiaryFixed => "#CF443B";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#BD3730";
    public string OnTertiaryFixedVariant => "#FFFBFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#E4F7FB";
    public string SurfaceContainer => "#DCF2F6";
    public string SurfaceContainerHigh => "#D5ECF1";
    public string SurfaceContainerHighest => "#CBE8ED";
}
