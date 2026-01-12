using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#003F79";
    public string OnPrimary => "#BDD5FF";
    public string PrimaryContainer => "#0075D7";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#003A90";
    public string OnSecondary => "#C5D3FF";
    public string SecondaryContainer => "#4570D2";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#631E7C";
    public string OnTertiary => "#F4C4FF";
    public string TertiaryContainer => "#9E58B6";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#850012";
    public string OnError => "#FFC7C2";
    public string ErrorContainer => "#D7383B";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F6F6FF";
    public string OnSurface => "#0E1E41";
    public string OnSurfaceVariant => "#303E63";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EEF0FF";
    public string SurfaceContainer => "#E2E7FF";
    public string SurfaceContainerHigh => "#DAE2FF";
    public string SurfaceContainerHighest => "#D2DCFF";
}
