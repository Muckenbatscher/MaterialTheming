using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFAFD6";
    public string OnPrimary => "#551A3D";
    public string PrimaryContainer => "#703054";
    public string OnPrimaryContainer => "#FFD8E8";

    public string Secondary => "#ABD0B1";
    public string OnSecondary => "#173721";
    public string SecondaryContainer => "#2D4E36";
    public string OnSecondaryContainer => "#C6ECCC";

    public string Tertiary => "#B6CF8F";
    public string OnTertiary => "#233606";
    public string TertiaryContainer => "#394D1B";
    public string OnTertiaryContainer => "#D2ECA9";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#12140B";
    public string OnSurface => "#E2E4D4";
    public string OnSurfaceVariant => "#C4C9B1";

    public string SurfaceContainerLowest => "#0D0F07";
    public string SurfaceContainerLow => "#1A1D13";
    public string SurfaceContainer => "#1E2117";
    public string SurfaceContainerHigh => "#292B21";
    public string SurfaceContainerHighest => "#33362B";
}
