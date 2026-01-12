using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#4A483B";
    public string OnPrimary => "#E6E2D1";
    public string PrimaryContainer => "#777566";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#494842";
    public string OnSecondary => "#E5E2D9";
    public string SecondaryContainer => "#76746D";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#454B2A";
    public string OnTertiary => "#E0E6BA";
    public string TertiaryContainer => "#727853";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#802C18";
    public string OnError => "#FFDAD1";
    public string ErrorContainer => "#BA573F";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFFBFF";
    public string OnSurface => "#2B2A26";
    public string OnSurfaceVariant => "#494843";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FDF9F4";
    public string SurfaceContainer => "#F7F3EE";
    public string SurfaceContainerHigh => "#F1EDE7";
    public string SurfaceContainerHighest => "#EBE8E1";
}
