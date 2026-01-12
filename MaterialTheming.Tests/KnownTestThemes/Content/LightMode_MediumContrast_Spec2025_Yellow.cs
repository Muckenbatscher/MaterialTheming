using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_MediumContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#393800";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#727000";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#39380C";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#716F3E";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#004002";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#397B31";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FDF9EB";
    public string OnSurface => "#12110A";
    public string OnSurfaceVariant => "#383727";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F7F4E5";
    public string SurfaceContainer => "#ECE8DA";
    public string SurfaceContainerHigh => "#E0DDCF";
    public string SurfaceContainerHighest => "#D5D2C4";
}
