using MaterialTheming.ColorDefinitions;

namespace MaterialTheming.Creation.ThemeBuilderBlocks;

public interface IWithSourceColorThemeBuilder<TBuilder> 
    where TBuilder : IBuildableThemeBuilder
{
    TBuilder WithSourceColor(HctColor color);
    TBuilder WithSourceColor(RgbColor color);
    TBuilder WithSourceColor(string htmlColor);
}
