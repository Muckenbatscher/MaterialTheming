using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_MediumContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#E4D6FF";
    public string OnPrimary => "#2E0F67";
    public string PrimaryContainer => "#9C82DA";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#E4D6FF";
    public string OnSecondary => "#2B1B51";
    public string SecondaryContainer => "#9987C5";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#FFCFE4";
    public string OnTertiary => "#451230";
    public string TertiaryContainer => "#C17C9E";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#1C1016";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F6D3E1";

    public string SurfaceContainerLowest => "#0E0509";
    public string SurfaceContainerLow => "#271A20";
    public string SurfaceContainer => "#32242A";
    public string SurfaceContainerHigh => "#3D2F35";
    public string SurfaceContainerHighest => "#493A40";
}
