namespace MaterialTheming;

/// <summary>
/// Defines a contract for theme builders that support configuring the <see cref="Platform"/> used when generating <see cref="ThemeColors" />.
/// </summary>
/// <typeparam name="TBuilder">The type of the theme builder that implements the <see cref="IBuildableThemeBuilder"/> interface.</typeparam>
public interface IWithPlatformThemeBuilder<TBuilder>
    where TBuilder : IBuildableThemeBuilder
{
    /// <summary>
    /// Specify the platform that is used to build the <see cref="ThemeColors" />.
    /// </summary>
    /// <param name="platform">The platform to use.</param>
    /// <returns>The <typeparamref name="TBuilder"/> with the specified platform.</returns>
    TBuilder WithPlatform(Platform platform);
}
