namespace MaterialTheming;

/// <summary>
/// Defines a contract for theme builders that support configuring the <see cref="SpecVersion"/> used when generating <see cref="ThemeColors" />.
/// </summary>
/// <typeparam name="TBuilder">The type of the theme builder that implements the <see cref="IBuildableThemeBuilder"/> interface.</typeparam>
public interface IWithSpecVersionThemeBuilder<TBuilder>
    where TBuilder : IBuildableThemeBuilder
{
    /// <summary>
    /// Specify the Material 3 spec version that is used to build the <see cref="ThemeColors" />.
    /// </summary>
    /// <param name="specVersion">The Material 3 spec version to use.</param>
    /// <returns>The <typeparamref name="TBuilder"/> with the specified Material 3 spec version.</returns>
    TBuilder WithSpecVersion(SpecVersion specVersion);
}
