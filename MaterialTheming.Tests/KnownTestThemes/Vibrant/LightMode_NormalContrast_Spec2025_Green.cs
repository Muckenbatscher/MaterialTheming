using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#006A2A";
    public string OnPrimary => "#CFFFCE";
    public string PrimaryContainer => "#63FC85";
    public string OnPrimaryContainer => "#005D24";

    public string Secondary => "#006940";
    public string OnSecondary => "#CAFFDB";
    public string SecondaryContainer => "#7AF8B1";
    public string OnSecondaryContainer => "#005C37";

    public string Tertiary => "#006572";
    public string OnTertiary => "#D9F8FF";
    public string TertiaryContainer => "#00E3FF";
    public string OnTertiaryContainer => "#004D58";

    public string Error => "#B02500";
    public string OnError => "#FFEFEC";
    public string ErrorContainer => "#F95630";
    public string OnErrorContainer => "#520C00";

    public string Surface => "#DCFFE5";
    public string OnSurface => "#063620";
    public string OnSurfaceVariant => "#38644A";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#C7FDD8";
    public string SurfaceContainer => "#BBF6CE";
    public string SurfaceContainerHigh => "#B2F1C7";
    public string SurfaceContainerHighest => "#A8ECC0";
}
