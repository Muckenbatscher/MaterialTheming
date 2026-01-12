using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#443400";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#86690B";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#3B3151";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#73678B";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#003B4C";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#37748B";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F3FAFF";
    public string OnSurface => "#0A1216";
    public string OnSurfaceVariant => "#2A383E";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EDF5FA";
    public string SurfaceContainer => "#E1E9EE";
    public string SurfaceContainerHigh => "#D6DEE3";
    public string SurfaceContainerHighest => "#CBD3D7";
}
