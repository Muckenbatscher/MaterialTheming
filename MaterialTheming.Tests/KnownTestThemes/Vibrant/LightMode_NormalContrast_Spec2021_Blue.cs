using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#005FB0";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#D5E3FF";
    public string OnPrimaryContainer => "#004787";

    public string Secondary => "#555D7E";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#DCE1FF";
    public string OnSecondaryContainer => "#3E4565";

    public string Tertiary => "#5D598A";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#E4DFFF";
    public string OnTertiaryContainer => "#454171";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#F9F9FF";
    public string OnSurface => "#171C24";
    public string OnSurfaceVariant => "#404753";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F0F3FF";
    public string SurfaceContainer => "#E9EEFA";
    public string SurfaceContainerHigh => "#E4E8F4";
    public string SurfaceContainerHighest => "#DEE2EF";
}
