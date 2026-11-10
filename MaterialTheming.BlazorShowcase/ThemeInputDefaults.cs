namespace MaterialTheming.BlazorShowcase;

public static class ThemeInputDefaults
{
    private const string DotnetBrandColor = "#512BD4";
    public static RgbColor SourceColor => RgbColor.FromHtml(DotnetBrandColor);
    public static RgbColor SecondSourceColor => RgbColor.FromHtml(DotnetBrandColor);
    public static Variant Variant => Variant.TonalSpot;
    public static ThemeMode Mode => ThemeMode.Light;
    public static ContrastLevel ContrastLevel => ContrastLevel.Normal;
    public static SpecVersion SpecVersion => SpecVersion.Spec2021;
    public static Platform Platform => Platform.Phone;
}
