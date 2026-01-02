namespace MaterialTheming.Creation;

internal interface INonPrimaryColorPaletteSpecResult : IColorPaletteSpecResult
{
    bool NormalizeChromaToPrimary { get; }
}
