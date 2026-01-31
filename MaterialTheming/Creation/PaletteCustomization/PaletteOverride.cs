using MaterialTheming.MaterialDesign.HctConversion;

namespace MaterialTheming.Creation.PaletteCustomization;

internal class PaletteOverride : IPaletteOverride, IPaletteOverrideResult
{
    private Func<double, double>? chromaModification;
    private Func<double, double>? hueModification;
    public IPaletteOverride WithChroma(double chroma)
    {
        chromaModification = _ => chroma;
        return this;
    }
    public IPaletteOverride WithChromaMultiplier(double chromaMultiplier)
    {
        chromaModification = chroma => chroma * chromaMultiplier;
        return this;
    }
    public IPaletteOverride WithHue(double hue)
    {
        hueModification = _ => MathUtils.SanitizeDegrees(hue);
        return this;
    }
    public IPaletteOverride WithHueShift(double hueShift)
    {
        hueModification = hue => MathUtils.SanitizeDegrees(hue + hueShift);
        return this;
    }

    public Func<double, double>? GetChromaModificationFunction() => chromaModification;
    public Func<double, double>? GetHueModificationFunction() => hueModification;
}
