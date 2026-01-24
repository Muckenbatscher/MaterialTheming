namespace MaterialTheming.Creation.PaletteCustomization;

public interface IPaletteOverride
{
    IPaletteOverride WithChroma(double chroma);
    IPaletteOverride WithChromaMultiplier(double chromaMultiplier);

    IPaletteOverride WithHue(double hue);
    IPaletteOverride WithHueShift(double hueShift);
}
