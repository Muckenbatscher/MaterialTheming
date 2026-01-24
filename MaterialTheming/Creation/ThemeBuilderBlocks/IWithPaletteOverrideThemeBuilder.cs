using MaterialTheming.Creation.PaletteCustomization;

namespace MaterialTheming.Creation.ThemeBuilderBlocks;

public interface IWithPaletteOverrideThemeBuilder<TBuilder>
    where TBuilder : IBuildableThemeBuilder
{
    TBuilder WithPrimaryPalette(Action<IPaletteOverride> paletteOverride);
    TBuilder WithSecondaryPalette(Action<IPaletteOverride> paletteOverride);
    TBuilder WithTertiaryPalette(Action<IPaletteOverride> paletteOverride);
    TBuilder WithErrorPalette(Action<IPaletteOverride> paletteOverride);
    TBuilder WithNeutralPalette(Action<IPaletteOverride> paletteOverride);
    TBuilder WithNeutralVariantPalette(Action<IPaletteOverride> paletteOverride);
}
