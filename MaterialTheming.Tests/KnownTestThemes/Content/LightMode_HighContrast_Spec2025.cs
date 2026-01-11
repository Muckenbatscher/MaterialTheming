using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_HighContrast_Spec2025 : ITestTheme
{
    public string SourceColor => "#E85DAE"; //magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#5A003D";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#8D0662";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#4E1738";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#713456";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#5D0900";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#901A05";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F8";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFECF2";
    public string SurfaceContainer => "#F2DDE4";
    public string SurfaceContainerHigh => "#E3CFD6";
    public string SurfaceContainerHighest => "#D5C2C8";
}
