using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Creation.ThemeBuilderBlocks;

public interface IWithContrastLevelThemeBuilder<TBuilder>
    where TBuilder : IBuildableThemeBuilder
{
    TBuilder WithContrastLevel(ContrastLevel contrastLevel);
}

public interface IWithContrastLevelValueThemeBuilder<TBuilder>
    where TBuilder : IBuildableThemeBuilder
{
    TBuilder WithContrastLevel(double contrastLevel);
}