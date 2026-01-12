using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFCFE4";
    public string OnPrimary => "#451230";
    public string PrimaryContainer => "#C17C9E";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#F6D3E1";
    public string OnSecondary => "#351F2A";
    public string SecondaryContainer => "#A78896";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#FFD3BB";
    public string OnTertiary => "#3D1D07";
    public string TertiaryContainer => "#B88668";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#181114";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#EAD8DE";

    public string SurfaceContainerLowest => "#0C0608";
    public string SurfaceContainerLow => "#231B1F";
    public string SurfaceContainer => "#2E2629";
    public string SurfaceContainerHigh => "#393034";
    public string SurfaceContainerHighest => "#443B3F";
}
