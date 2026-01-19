using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Creation.ThemeBuilderBlocks;

public interface IWithSpecVersionThemeBuilder<TBuilder>
    where TBuilder : IBuildableThemeBuilder
{
    /// <summary>
    /// Specify the Material 3 spec version that is used to build the <see cref="Theme" />.
    /// </summary>
    /// <param name="specVersion">The Material 3 spec version to use.</param>
    /// <returns>The <typeparamref name="TBuilder"/> with the specified Material 3 spec version.</returns>
    TBuilder WithSpecVersion(SpecVersion specVersion);
}
