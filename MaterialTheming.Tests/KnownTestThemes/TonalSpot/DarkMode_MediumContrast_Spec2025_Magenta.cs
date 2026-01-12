using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#EEB7D0";
    public string OnPrimary => "#502A3E";
    public string PrimaryContainer => "#95677D";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#E0BDCC";
    public string OnSecondary => "#472F3A";
    public string SecondaryContainer => "#896D79";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#F9E0FF";
    public string OnTertiary => "#5B4267";
    public string TertiaryContainer => "#F0CEFD";
    public string OnTertiaryContainer => "#52395E";

    public string Error => "#FF9DA8";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#C44B5F";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#120D0F";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#C6B4BB";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#191115";
    public string SurfaceContainer => "#20171B";
    public string SurfaceContainerHigh => "#271D21";
    public string SurfaceContainerHighest => "#2E2328";
}
