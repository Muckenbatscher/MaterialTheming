namespace MaterialTheming;

/// <summary>
/// Defines a contract for theme builders that support configuring the <see cref="ThemeMode"/> used when generating <see cref="ThemeColors" />.
/// </summary>
/// <typeparam name="TBuilder">The type of the theme builder that implements the <see cref="IBuildableThemeBuilder"/> interface.</typeparam>
public interface IWithModeThemeBuilder<TBuilder>
    where TBuilder : IBuildableThemeBuilder
{
    /// <summary>
    /// Specify the mode that is used to build the <see cref="ThemeColors" />.
    /// </summary>
    /// <param name="mode">The mode to use.</param>
    /// <returns>The <typeparamref name="TBuilder"/> with the specified mode.</returns>
    TBuilder WithMode(ThemeMode mode);
}
