using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#D7C2B8";
    public string OnPrimary => "#4B3D36";
    public string PrimaryContainer => "#52443C";
    public string OnPrimaryContainer => "#E1CCC2";

    public string Secondary => "#A69C97";
    public string OnSecondary => "#251F1C";
    public string SecondaryContainer => "#413A36";
    public string OnSecondaryContainer => "#C8BDB8";

    public string Tertiary => "#FFEEDB";
    public string OnTertiary => "#6E5634";
    public string TertiaryContainer => "#FFDDB1";
    public string OnTertiaryContainer => "#654E2C";

    public string Error => "#ED7F64";
    public string OnError => "#450900";
    public string ErrorContainer => "#7E2B17";
    public string OnErrorContainer => "#FF9B82";

    public string Surface => "#100E0D";
    public string OnSurface => "#EEE3DF";
    public string OnSurfaceVariant => "#B2A9A5";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#151311";
    public string SurfaceContainer => "#1C1917";
    public string SurfaceContainerHigh => "#231F1D";
    public string SurfaceContainerHighest => "#2A2522";
}
