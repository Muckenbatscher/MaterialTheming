using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#CB97FF";
    public string OnPrimary => "#46007C";
    public string PrimaryContainer => "#C185FF";
    public string OnPrimaryContainer => "#360062";

    public string Secondary => "#E097FD";
    public string OnSecondary => "#530C70";
    public string SecondaryContainer => "#692886";
    public string OnSecondaryContainer => "#F0BFFF";

    public string Tertiary => "#FF95A1";
    public string OnTertiary => "#680922";
    public string TertiaryContainer => "#FE7E8F";
    public string OnTertiaryContainer => "#570019";

    public string Error => "#FF6E84";
    public string OnError => "#490013";
    public string ErrorContainer => "#A70138";
    public string OnErrorContainer => "#FFB2B9";

    public string Surface => "#1B0425";
    public string OnSurface => "#F9DCFF";
    public string OnSurfaceVariant => "#C1A0CB";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#21072D";
    public string SurfaceContainer => "#290C36";
    public string SurfaceContainerHigh => "#31113F";
    public string SurfaceContainerHighest => "#391648";
}
