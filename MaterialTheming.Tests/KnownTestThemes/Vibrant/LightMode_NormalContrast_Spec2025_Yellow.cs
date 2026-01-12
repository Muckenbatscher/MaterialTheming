using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#605E00";
    public string OnPrimary => "#FDFA04";
    public string PrimaryContainer => "#F5F200";
    public string OnPrimaryContainer => "#5B5A00";

    public string Secondary => "#6D5A00";
    public string OnSecondary => "#FFF2CE";
    public string SecondaryContainer => "#FCD83F";
    public string OnSecondaryContainer => "#5B4B00";

    public string Tertiary => "#755700";
    public string OnTertiary => "#FFF1DB";
    public string TertiaryContainer => "#F7BE26";
    public string OnTertiaryContainer => "#533D00";

    public string Error => "#B02500";
    public string OnError => "#FFEFEC";
    public string ErrorContainer => "#F95630";
    public string OnErrorContainer => "#520C00";

    public string Surface => "#FFF6E1";
    public string OnSurface => "#392E00";
    public string OnSurfaceVariant => "#695B23";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0C4";
    public string SurfaceContainer => "#FFE796";
    public string SurfaceContainerHigh => "#FAE18C";
    public string SurfaceContainerHighest => "#F5DC81";
}
