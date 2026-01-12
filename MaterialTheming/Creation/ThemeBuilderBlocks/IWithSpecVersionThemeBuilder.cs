using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Creation.ThemeBuilderBlocks;

public interface IWithSpecVersionThemeBuilder<TBuilder>
    where TBuilder : IBuildableThemeBuilder
{
    TBuilder WithSpecVersion(SpecVersion specVersion);
}
