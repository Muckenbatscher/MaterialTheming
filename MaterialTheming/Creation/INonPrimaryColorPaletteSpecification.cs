using MaterialTheming.ColorDefinitions;

namespace MaterialTheming.Creation;

public interface INonPrimaryColorPaletteSpecification
{
    INonPrimaryColorPaletteSpecification WithBaseColor(string baseColorHtml);
    INonPrimaryColorPaletteSpecification WithBaseColor(byte red, byte green, byte blue);
    INonPrimaryColorPaletteSpecification WithBaseColor(RgbColor baseColor);
    INonPrimaryColorPaletteSpecification WithBaseColor(HctColor baseColor);
    INonPrimaryColorPaletteSpecification WithBaseColorHue(double hue);

    INonPrimaryColorPaletteSpecification WithFixedTargetChroma(bool useFixedTargetChroma = true);
    INonPrimaryColorPaletteSpecification WithFixedChroma(double chroma);
    INonPrimaryColorPaletteSpecification WithChromaNormalizedToPrimary(bool normalizeChroma = true);
}
