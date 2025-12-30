using MaterialTheming.ColorDefinitions;

namespace MaterialTheming.Creation;

public interface IColorPaletteSpecification
{
    IColorPaletteSpecification WithBaseColor(string baseColorHtml);
    IColorPaletteSpecification WithBaseColor(byte red, byte green, byte blue);
    IColorPaletteSpecification WithBaseColor(RgbColor baseColor);
    IColorPaletteSpecification WithBaseColor(HctColor baseColor);
    IColorPaletteSpecification WithBaseColorHue(double hue);

    IColorPaletteSpecification WithNormalizedChroma(bool normalizeChroma = true);
    IColorPaletteSpecification WithFixedChroma(double chroma);
}
