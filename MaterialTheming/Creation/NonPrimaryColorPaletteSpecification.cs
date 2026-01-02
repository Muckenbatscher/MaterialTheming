using MaterialTheming.ColorDefinitions;
using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Creation;

internal class NonPrimaryColorPaletteSpecification : INonPrimaryColorPaletteSpecification, INonPrimaryColorPaletteSpecResult
{
    public NonPrimaryColorPaletteSpecification(ColorPaletteType paletteType)
    {
        PaletteType = paletteType;
        BaseColor = RgbColor.Empty;
        UseFixedTargetChroma = true;
        NormalizeChromaToPrimary = true;
        UseFixedChroma = false;
        FixedChroma = 0.0;
    }

    public ColorPaletteType PaletteType { get; }

    public bool BaseColorSpecified => BaseColor != RgbColor.Empty;

    public RgbColor BaseColor { get; private set; }
    public bool UseFixedTargetChroma { get; private set; }
    public bool NormalizeChromaToPrimary { get; private set; }
    public bool UseFixedChroma { get; private set; }
    public double FixedChroma { get; private set; }

    public INonPrimaryColorPaletteSpecification WithBaseColor(string baseColorHtml)
    {
        BaseColor = RgbColor.FromHtml(baseColorHtml);
        return this;
    }
    public INonPrimaryColorPaletteSpecification WithBaseColor(byte red, byte green, byte blue)
    {
        BaseColor = RgbColor.FromRgb(red, green, blue);
        return this;
    }
    public INonPrimaryColorPaletteSpecification WithBaseColor(RgbColor baseColor)
    {
        BaseColor = baseColor;
        return this;
    }
    public INonPrimaryColorPaletteSpecification WithBaseColor(HctColor baseColor)
    {
        BaseColor = baseColor.ToRgbColor();
        return this;
    }
    public INonPrimaryColorPaletteSpecification WithBaseColorHue(double hue)
    {
        var paletteTypeTargetChroma = TargetChromaProvider.GetTargetChromaForPaletteType(PaletteType);
        return WithBaseColor(HctColor.From(hue, paletteTypeTargetChroma, 50));
    }

    public INonPrimaryColorPaletteSpecification WithFixedTargetChroma(bool useFixedTargetChroma = true)
    {
        UseFixedTargetChroma = useFixedTargetChroma;
        return this;
    }
    public INonPrimaryColorPaletteSpecification WithFixedChroma(double chroma)
    {
        UseFixedTargetChroma = false;
        UseFixedChroma = true;
        FixedChroma = chroma;
        return this;
    }
    public INonPrimaryColorPaletteSpecification WithChromaNormalizedToPrimary(bool normalizeChroma = true)
    {
        NormalizeChromaToPrimary = normalizeChroma;
        return this;
    }
}
