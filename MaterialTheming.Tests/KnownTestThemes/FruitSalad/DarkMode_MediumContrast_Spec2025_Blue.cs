using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_MediumContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#79EDFF";
    public string OnPrimary => "#002A30";
    public string PrimaryContainer => "#009FB1";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#98E9F7";
    public string OnSecondary => "#002A30";
    public string SecondaryContainer => "#499CA9";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#CBDDFF";
    public string OnTertiary => "#00264C";
    public string TertiaryContainer => "#7092C6";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#0E141C";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#D2DDF2";

    public string SurfaceContainerLowest => "#04080F";
    public string SurfaceContainerLow => "#191E26";
    public string SurfaceContainer => "#232831";
    public string SurfaceContainerHigh => "#2E333C";
    public string SurfaceContainerHighest => "#393E47";
}
