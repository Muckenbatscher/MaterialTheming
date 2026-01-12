using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#782721";
    public string OnPrimary => "#FFCEC9";
    public string PrimaryContainer => "#B8574E";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#1F4856";
    public string OnSecondary => "#B8E0F1";
    public string SecondaryContainer => "#537A8A";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#004A59";
    public string OnTertiary => "#93E5FF";
    public string TertiaryContainer => "#008098";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#85112F";
    public string OnError => "#FFCDD1";
    public string ErrorContainer => "#C8475D";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F6";
    public string OnSurface => "#40170B";
    public string OnSurfaceVariant => "#673526";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1ED";
    public string SurfaceContainer => "#FFE9E4";
    public string SurfaceContainerHigh => "#FFE2DA";
    public string SurfaceContainerHighest => "#FFDBD1";
}
