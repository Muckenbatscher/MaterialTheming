using System.ComponentModel;

namespace MaterialTheming.MaterialDesign;

internal class TargetChromaProvider
{
    public static double GetTargetChromaForPaletteType(ColorPaletteType paletteType)
    {
        return paletteType switch
        {
            ColorPaletteType.Primary => 32,
            ColorPaletteType.Secondary => 16,
            ColorPaletteType.Tertiary => 24,
            ColorPaletteType.Error => 85,
            ColorPaletteType.Neutral => 5,
            ColorPaletteType.NeutralVariant => 8,
            _ => throw new InvalidEnumArgumentException(nameof(paletteType), (int)paletteType, paletteType.GetType()),
        };
    }
}
