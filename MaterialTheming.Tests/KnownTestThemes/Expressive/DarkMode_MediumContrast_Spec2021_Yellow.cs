using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFCFE4";
    public string OnPrimary => "#480E31";
    public string PrimaryContainer => "#C679A0";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#C0E6C6";
    public string OnSecondary => "#0B2C17";
    public string SecondaryContainer => "#76997D";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#CCE5A3";
    public string OnTertiary => "#192A00";
    public string TertiaryContainer => "#81995E";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#12140B";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DADFC6";

    public string SurfaceContainerLowest => "#060802";
    public string SurfaceContainerLow => "#1C1F15";
    public string SurfaceContainer => "#26291F";
    public string SurfaceContainerHigh => "#313429";
    public string SurfaceContainerHighest => "#3C3F33";
}
