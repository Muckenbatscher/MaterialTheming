using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class DarkMode_MediumContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#E4E264";
    public string OnPrimary => "#282700";
    public string PrimaryContainer => "#B2B037";
    public string OnPrimaryContainer => "#222200";

    public string Secondary => "#E2DFA4";
    public string OnSecondary => "#282700";
    public string SecondaryContainer => "#95935F";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#E7D5FF";
    public string OnTertiary => "#330A67";
    public string TertiaryContainer => "#BF9AF8";
    public string OnTertiaryContainer => "#2E0162";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#14140C";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E0DDC6";

    public string SurfaceContainerLowest => "#080803";
    public string SurfaceContainerLow => "#1E1E15";
    public string SurfaceContainer => "#29281F";
    public string SurfaceContainerHigh => "#34332A";
    public string SurfaceContainerHighest => "#3F3E34";
}
