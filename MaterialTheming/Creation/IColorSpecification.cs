using MaterialTheming.ColorDefinitions;

namespace MaterialTheming.Creation;

public interface IColorSpecification
{
    IColorSpecification WithBaseColor(string baseColorHtml);
    IColorSpecification WithBaseColor(byte red, byte green, byte blue);
    IColorSpecification WithBaseColor(RgbColor baseColor);
    IColorSpecification WithBaseColor(HctColor baseColor);

    IColorSpecification WithNormalizedChroma(bool normalizeChroma = true);
    IColorSpecification WithFixedChroma(double chroma);

    IColorSpecification WithNormalizedTone(bool normalizedTone = true);
    IColorSpecification WithFixedTone(double tone);
}
