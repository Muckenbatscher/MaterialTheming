using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#63FC85";
    public string OnPrimary => "#00521E";
    public string PrimaryContainer => "#02BF51";
    public string OnPrimaryContainer => "#002108";

    public string Secondary => "#7AF8B1";
    public string OnSecondary => "#005130";
    public string SecondaryContainer => "#008652";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#86ECFF";
    public string OnTertiary => "#004C56";
    public string TertiaryContainer => "#00E3FF";
    public string OnTertiaryContainer => "#00424C";

    public string Error => "#FFA089";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#D53D18";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#001207";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#94C4A4";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#00180A";
    public string SurfaceContainer => "#001F0F";
    public string SurfaceContainerHigh => "#002613";
    public string SurfaceContainerHighest => "#002D18";
}
