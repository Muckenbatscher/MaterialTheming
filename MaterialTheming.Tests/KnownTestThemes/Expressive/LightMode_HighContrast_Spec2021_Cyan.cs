using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#382A00";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#5B4600";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#302746";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#4E4465";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#00313F";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#005065";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F3FAFF";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EAF2F7";
    public string SurfaceContainer => "#DCE4E8";
    public string SurfaceContainerHigh => "#CED6DA";
    public string SurfaceContainerHighest => "#C0C8CC";
}
