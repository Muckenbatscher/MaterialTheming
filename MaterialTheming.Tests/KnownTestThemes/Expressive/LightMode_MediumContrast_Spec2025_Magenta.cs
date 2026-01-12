using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#722553";
    public string OnPrimary => "#FFCCE2";
    public string PrimaryContainer => "#AE5787";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#1A4A46";
    public string OnSecondary => "#B3E3DD";
    public string SecondaryContainer => "#4F7D78";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#004C44";
    public string OnTertiary => "#6AEFDC";
    public string TertiaryContainer => "#008376";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#85112F";
    public string OnError => "#FFCDD1";
    public string ErrorContainer => "#C8475D";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F8";
    public string OnSurface => "#3D162C";
    public string OnSurfaceVariant => "#61354C";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#FFE8F0";
    public string SurfaceContainerHigh => "#FFE0EC";
    public string SurfaceContainerHighest => "#FFD8E8";
}
