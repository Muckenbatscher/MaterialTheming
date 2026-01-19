namespace MaterialTheming.Creation.ThemeBuilderBlocks;

public interface IWithPlatformThemeBuilder<TBuilder>
    where TBuilder : IBuildableThemeBuilder
{
    /// <summary>
    /// Specify the platform that is used to build the <see cref="Theme" />.
    /// </summary>
    /// <param name="platform">The platform to use.</param>
    /// <returns>The <typeparamref name="TBuilder"/> with the specified platform.</returns>
    TBuilder WithPlatform(Platform platform);
}
