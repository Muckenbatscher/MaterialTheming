using MaterialTheming.ColorDefinitions;
using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Creation;

internal class NonPrimaryColorPaletteSpecification : INonPrimaryColorPaletteSpecification, INonPrimaryColorPaletteSpecResult
{
    private readonly ColorPaletteSpecification _colorPaletteSpecification;

    public NonPrimaryColorPaletteSpecification(ColorPaletteType paletteType)
    {
        _colorPaletteSpecification = new ColorPaletteSpecification(paletteType);
        WithChromaNormalizedToPrimary(true);
    }

    public ColorPaletteType PaletteType => _colorPaletteSpecification.PaletteType;

    public bool BaseColorSpecified => _colorPaletteSpecification.BaseColorSpecified;

    public RgbColor BaseColor => _colorPaletteSpecification.BaseColor;
    public bool UseFixedTargetChroma => _colorPaletteSpecification.UseFixedTargetChroma;
    public bool UseFixedChroma => _colorPaletteSpecification.UseFixedChroma;
    public double FixedChroma => _colorPaletteSpecification.FixedChroma;


    public bool NormalizeChromaToPrimary { get; private set; }

    public INonPrimaryColorPaletteSpecification WithBaseColor(string baseColorHtml)
    {
        _colorPaletteSpecification.WithBaseColor(baseColorHtml);
        return this;
    }
    public INonPrimaryColorPaletteSpecification WithBaseColor(byte red, byte green, byte blue)
    {
        _colorPaletteSpecification.WithBaseColor(red, green, blue);
        return this;
    }
    public INonPrimaryColorPaletteSpecification WithBaseColor(RgbColor baseColor)
    {
        _colorPaletteSpecification.WithBaseColor(baseColor);
        return this;
    }
    public INonPrimaryColorPaletteSpecification WithBaseColor(HctColor baseColor)
    {
        _colorPaletteSpecification.WithBaseColor(baseColor);
        return this;
    }
    public INonPrimaryColorPaletteSpecification WithBaseColorHue(double hue)
    {
        _colorPaletteSpecification.WithBaseColorHue(hue);
        return this;
    }

    public INonPrimaryColorPaletteSpecification WithFixedTargetChroma(bool useFixedTargetChroma = true)
    {
        _colorPaletteSpecification.WithFixedTargetChroma(useFixedTargetChroma);
        if (!useFixedTargetChroma)
            WithChromaNormalizedToPrimary(false);
        return this;
    }
    public INonPrimaryColorPaletteSpecification WithFixedChroma(double chroma)
    {
        _colorPaletteSpecification.WithFixedChroma(chroma);
        return this;
    }
    public INonPrimaryColorPaletteSpecification WithChromaNormalizedToPrimary(bool normalizeChroma = true)
    {
        NormalizeChromaToPrimary = normalizeChroma;
        if (!normalizeChroma)
            _colorPaletteSpecification.WithFixedTargetChroma(false);
        return this;
    }
}
