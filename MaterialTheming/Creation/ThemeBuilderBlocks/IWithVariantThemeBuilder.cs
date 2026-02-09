namespace MaterialTheming;

/// <summary>
/// Defines a contract for theme builders that support configuring the <see cref="Variant"/> used when generating <see cref="ThemeColors" />.
/// </summary>
/// <typeparam name="TBuilder">The type of the theme builder that implements the <see cref="IBuildableThemeBuilder"/> interface.</typeparam>
public interface IWithVariantThemeBuilder<TBuilder>
    where TBuilder : IBuildableThemeBuilder
{
    /// <summary>
    /// Specify the variant that is used to build the <see cref="ThemeColors" />.
    /// </summary>
    /// <param name="variant">The variant to use.</param>
    /// <returns>The <typeparamref name="TBuilder"/> with the specified variant.</returns>
    TBuilder WithVariant(Variant variant);
}
