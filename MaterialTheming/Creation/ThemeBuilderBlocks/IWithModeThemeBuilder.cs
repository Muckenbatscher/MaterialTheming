using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Creation.ThemeBuilderBlocks;

public interface IWithModeThemeBuilder<TBuilder>
    where TBuilder : IBuildableThemeBuilder
{
    TBuilder WithMode(ThemeMode mode);
}
