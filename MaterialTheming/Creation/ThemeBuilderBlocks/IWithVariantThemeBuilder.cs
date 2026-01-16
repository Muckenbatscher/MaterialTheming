using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Creation.ThemeBuilderBlocks;

public interface IWithVariantThemeBuilder<TBuilder>
    where TBuilder : IBuildableThemeBuilder
{
    /// <summary>
    /// Specify the variant that is used to build the <see cref="Theme" />.
    /// </summary>
    /// <param name="variant">The variant to use.</param>
    /// <returns>The <typeparamref name="TBuilder"/> with the specified variant.</returns>
    TBuilder WithVariant(Variant variant);
}
