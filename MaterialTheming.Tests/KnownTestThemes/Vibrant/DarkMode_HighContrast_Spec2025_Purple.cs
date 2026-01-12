using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#F2DFFF";
    public string OnPrimary => "#430077";
    public string PrimaryContainer => "#C489FF";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#F9DCFF";
    public string OnSecondary => "#4B0068";
    public string SecondaryContainer => "#CF88EC";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#FFDDDF";
    public string OnTertiary => "#5E011C";
    public string TertiaryContainer => "#FE7E8F";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFDDDF";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#FF798C";
    public string OnErrorContainer => "#000000";

    public string Surface => "#1B0425";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F9DCFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#21072D";
    public string SurfaceContainer => "#290C36";
    public string SurfaceContainerHigh => "#31113F";
    public string SurfaceContainerHighest => "#391648";
}
