using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFEBF2";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#FEA9D3";
    public string OnPrimaryContainer => "#1F0013";

    public string Secondary => "#D4F9D9";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#A7CCAD";
    public string OnSecondaryContainer => "#000F04";

    public string Tertiary => "#DFF9B6";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#B2CB8C";
    public string OnTertiaryContainer => "#060E00";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#12140B";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1E2117";
    public string SurfaceContainer => "#2F3227";
    public string SurfaceContainerHigh => "#3A3D31";
    public string SurfaceContainerHighest => "#45483C";
}
