using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2021 : ITestTheme
{
    public string SourceColor => "#945CCD"; //purple
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#F9EBFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#DAB3FF";
    public string OnPrimaryContainer => "#15002C";

    public string Secondary => "#FFEAFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#D8B8DD";
    public string OnSecondaryContainer => "#16041D";

    public string Tertiary => "#FFEAF7";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#E9B2DE";
    public string OnTertiaryContainer => "#1D001C";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#16111B";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#231D28";
    public string SurfaceContainer => "#342E39";
    public string SurfaceContainerHigh => "#3F3944";
    public string SurfaceContainerHighest => "#4B4450";
}
