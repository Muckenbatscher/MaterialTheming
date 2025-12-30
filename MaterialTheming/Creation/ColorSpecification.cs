using MaterialTheming.ColorDefinitions;

namespace MaterialTheming.Creation;

internal class ColorSpecification : IColorSpecification
{
    public ColorSpecification()
    {
        BaseColor = RgbColor.Empty;
        NormalizeChroma = true;
        FixedChroma = 0.0;
        NormalizeTone = true;
        FixedTone = 0.0;
    }

    public bool BaseColorSpecified => BaseColor != RgbColor.Empty;

    public RgbColor BaseColor { get; private set; }
    public bool NormalizeChroma { get; private set; }
    public bool UseFixedChroma { get; private set; }
    public double FixedChroma { get; private set; }
    public bool NormalizeTone { get; private set; }
    public bool UseFixedTone { get; private set; }
    public double FixedTone { get; private set; }

    public IColorSpecification WithBaseColor(string baseColorHtml)
    {
        BaseColor = RgbColor.FromHtml(baseColorHtml);
        return this;
    }
    public IColorSpecification WithBaseColor(byte red, byte green, byte blue)
    {
        BaseColor = RgbColor.FromRgb(red, green, blue);
        return this;
    }
    public IColorSpecification WithBaseColor(RgbColor baseColor)
    {
        BaseColor = baseColor;
        return this;
    }
    public IColorSpecification WithBaseColor(HctColor baseColor)
    {
        BaseColor = baseColor.ToRgbColor();
        return this;
    }

    public IColorSpecification WithNormalizedChroma(bool normalizeChroma = true)
    {
        NormalizeChroma = normalizeChroma;
        return this;
    }
    public IColorSpecification WithFixedChroma(double chroma)
    {
        NormalizeChroma = false;
        UseFixedChroma = true;
        FixedChroma = chroma;
        return this;
    }

    public IColorSpecification WithNormalizedTone(bool normalizeTone = true)
    {
        NormalizeChroma = normalizeTone;
        return this;
    }
    public IColorSpecification WithFixedTone(double tone)
    {
        NormalizeTone = false;
        UseFixedTone = true;
        FixedTone = tone;
        return this;

    }
}
