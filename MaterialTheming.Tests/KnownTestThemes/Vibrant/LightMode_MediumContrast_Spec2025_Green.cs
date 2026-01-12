using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#004A1B";
    public string OnPrimary => "#56F07B";
    public string PrimaryContainer => "#008737";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#00492B";
    public string OnSecondary => "#6DECA7";
    public string SecondaryContainer => "#008652";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#004650";
    public string OnTertiary => "#51E6FF";
    public string TertiaryContainer => "#008091";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#7D1800";
    public string OnError => "#FFC7BA";
    public string ErrorContainer => "#D53D18";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#DCFFE5";
    public string OnSurface => "#002513";
    public string OnSurfaceVariant => "#1B472F";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#C7FDD8";
    public string SurfaceContainer => "#BBF6CE";
    public string SurfaceContainerHigh => "#B2F1C7";
    public string SurfaceContainerHighest => "#A8ECC0";
}
