using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFECE8";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#FFAF9E";
    public string OnPrimaryContainer => "#200100";

    public string Secondary => "#CDFAE5";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#A1CCB8";
    public string OnSecondaryContainer => "#000E08";

    public string Tertiary => "#B5FDFA";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#88CFCD";
    public string OnTertiaryContainer => "#000E0D";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#0D1511";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#19211D";
    public string SurfaceContainer => "#2A322D";
    public string SurfaceContainerHigh => "#353D38";
    public string SurfaceContainerHighest => "#404943";
}
