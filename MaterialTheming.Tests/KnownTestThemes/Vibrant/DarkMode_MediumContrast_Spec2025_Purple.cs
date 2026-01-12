using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#D3A6FF";
    public string OnPrimary => "#430077";
    public string PrimaryContainer => "#C185FF";
    public string OnPrimaryContainer => "#220041";

    public string Secondary => "#E49EFF";
    public string OnSecondary => "#4B0069";
    public string SecondaryContainer => "#9C58B8";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#FF9DA8";
    public string OnTertiary => "#5F011C";
    public string TertiaryContainer => "#FE7E8F";
    public string OnTertiaryContainer => "#3F000F";

    public string Error => "#FF9DA8";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#D73357";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#1B0425";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#CFADD9";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#21072D";
    public string SurfaceContainer => "#290C36";
    public string SurfaceContainerHigh => "#31113F";
    public string SurfaceContainerHighest => "#391648";
}
