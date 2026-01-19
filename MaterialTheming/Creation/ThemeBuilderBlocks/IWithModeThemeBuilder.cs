using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Creation.ThemeBuilderBlocks;

public interface IWithModeThemeBuilder<TBuilder>
    where TBuilder : IBuildableThemeBuilder
{
    /// <summary>
    /// Specify the mode that is used to build the <see cref="Theme" />.
    /// </summary>
    /// <param name="mode">The mode to use.</param>
    /// <returns>The <typeparamref name="TBuilder"/> with the specified mode.</returns>
    TBuilder WithMode(ThemeMode mode);
}
