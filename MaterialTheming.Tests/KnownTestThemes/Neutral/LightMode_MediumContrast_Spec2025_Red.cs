using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#4F3F3D";
    public string OnPrimary => "#ECD5D2";
    public string PrimaryContainer => "#83706E";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#494140";
    public string OnSecondary => "#E4D7D5";
    public string SecondaryContainer => "#7C7271";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#593A47";
    public string OnTertiary => "#FBCEDF";
    public string TertiaryContainer => "#8F6A79";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#7A2333";
    public string OnError => "#FFCDD1";
    public string ErrorContainer => "#B95463";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F7";
    public string OnSurface => "#282322";
    public string OnSurfaceVariant => "#484141";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FAF2F1";
    public string SurfaceContainer => "#F5ECEB";
    public string SurfaceContainerHigh => "#F0E6E5";
    public string SurfaceContainerHighest => "#EBE0DF";
}
