using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#2160A7";
    public string OnPrimary => "#F8F8FF";
    public string PrimaryContainer => "#9CC3FF";
    public string OnPrimaryContainer => "#003D74";

    public string Secondary => "#416753";
    public string OnSecondary => "#E6FFEE";
    public string SecondaryContainer => "#D0FBE0";
    public string OnSecondaryContainer => "#3C624E";

    public string Tertiary => "#006E40";
    public string OnTertiary => "#E7FFEB";
    public string TertiaryContainer => "#9AFDBF";
    public string OnTertiaryContainer => "#006239";

    public string Error => "#AC3434";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#F56965";
    public string OnErrorContainer => "#65000B";

    public string Surface => "#F9F9FF";
    public string OnSurface => "#193355";
    public string OnSurfaceVariant => "#486085";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F0F3FF";
    public string SurfaceContainer => "#E7EEFF";
    public string SurfaceContainerHigh => "#DEE9FF";
    public string SurfaceContainerHighest => "#D5E3FF";
}
