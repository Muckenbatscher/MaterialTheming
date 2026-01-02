using MaterialTheming.ColorDefinitions;
using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Creation;

internal class ColorPaletteSpecification : IColorPaletteSpecification, IColorPaletteSpecResult
{
    public ColorPaletteSpecification(ColorPaletteType paletteType)
    {
        PaletteType = paletteType;
        BaseColor = RgbColor.Empty;
        UseFixedTargetChroma = true;
        UseFixedChroma = false;
        FixedChroma = 0.0;
    }

    public ColorPaletteType PaletteType { get; }

    public bool BaseColorSpecified => BaseColor != RgbColor.Empty;

    public RgbColor BaseColor { get; private set; }
    public bool UseFixedTargetChroma { get; private set; }
    public bool UseFixedChroma { get; private set; }
    public double FixedChroma { get; private set; }

    public IColorPaletteSpecification WithBaseColor(string baseColorHtml)
    {
        BaseColor = RgbColor.FromHtml(baseColorHtml);
        return this;
    }
    public IColorPaletteSpecification WithBaseColor(byte red, byte green, byte blue)
    {
        BaseColor = RgbColor.FromRgb(red, green, blue);
        return this;
    }
    public IColorPaletteSpecification WithBaseColor(RgbColor baseColor)
    {
        BaseColor = baseColor;
        return this;
    }
    public IColorPaletteSpecification WithBaseColor(HctColor baseColor)
    {
        BaseColor = baseColor.ToRgbColor();
        return this;
    }
    public IColorPaletteSpecification WithBaseColorHue(double hue)
    {
        var paletteTypeTargetChroma = TargetChromaProvider.GetTargetChromaForPaletteType(PaletteType);
        return WithBaseColor(HctColor.From(hue, paletteTypeTargetChroma, 50));
    }

    public IColorPaletteSpecification WithFixedTargetChroma(bool useFixedTargetChroma = true)
    {
        UseFixedTargetChroma = useFixedTargetChroma;
        return this;
    }
    public IColorPaletteSpecification WithFixedChroma(double chroma)
    {
        UseFixedTargetChroma = false;
        UseFixedChroma = true;
        FixedChroma = chroma;
        return this;
    }
}
