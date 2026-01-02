using MaterialTheming.ColorDefinitions;
using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Creation;

internal interface IColorPaletteSpecResult
{
    bool BaseColorSpecified { get; }
    ColorPaletteType PaletteType { get; }
    RgbColor BaseColor { get; }
    bool UseFixedTargetChroma { get; }
    bool UseFixedChroma { get; }
    double FixedChroma { get; }
}
