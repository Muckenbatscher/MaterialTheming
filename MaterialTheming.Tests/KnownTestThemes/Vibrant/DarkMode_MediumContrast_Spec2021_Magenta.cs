using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFCFE4";
    public string OnPrimary => "#4E0035";
    public string PrimaryContainer => "#FF3DB9";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#FFD0DB";
    public string OnSecondary => "#3E1A25";
    public string SecondaryContainer => "#B68390";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#FFD1D3";
    public string OnTertiary => "#45151A";
    public string TertiaryContainer => "#C57D81";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#1C1016";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F0D5E0";

    public string SurfaceContainerLowest => "#0E0509";
    public string SurfaceContainerLow => "#271A20";
    public string SurfaceContainer => "#32242A";
    public string SurfaceContainerHigh => "#3D2F35";
    public string SurfaceContainerHighest => "#493A40";
}
