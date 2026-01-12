using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#B4007F";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FFD8E8";
    public string OnPrimaryContainer => "#8A0060";

    public string Secondary => "#7E525E";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FFD9E1";
    public string OnSecondaryContainer => "#643B46";

    public string Tertiary => "#8B4C51";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FFDADA";
    public string OnTertiaryContainer => "#6E353A";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FFF8F8";
    public string OnSurface => "#24181E";
    public string OnSurfaceVariant => "#54424A";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#FFE8F0";
    public string SurfaceContainerHigh => "#FAE2EB";
    public string SurfaceContainerHighest => "#F4DDE5";
}
