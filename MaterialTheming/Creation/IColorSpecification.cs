using MaterialTheming.ColorDefinitions;

namespace MaterialTheming.Creation;

public interface IColorSpecification
{
    IColorSpecification WithBaseColor(string baseColorHtml);
    IColorSpecification WithBaseColor(int r, int g, int b);
    IColorSpecification WithBaseColor(RgbColor baseColor);
    IColorSpecification WithBaseColor(HctColor baseColor);

    IColorSpecification WithNormalizedChroma(bool normalizedChroma);
    IColorSpecification WithFixedChroma(double chroma);

    IColorSpecification WithNormalizedTone(bool normalizedTone);
    IColorSpecification WithFixedTone(double tone);
}
