using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Creation.ThemeBuilderBlocks;

public interface IWithPlatformThemeBuilder<TBuilder>
    where TBuilder : IBuildableThemeBuilder
{
    TBuilder WithPlatform(Platform platform);
}
