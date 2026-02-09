namespace MaterialTheming;

/// <summary>
/// Defines a contract for theme builders that support configuring a single source color 
/// (in RGB or HCT color space) used when generating <see cref="ThemeColors" />.
/// </summary>
/// <typeparam name="TBuilder">The type of the theme builder that implements the <see cref="IBuildableThemeBuilder"/> interface.</typeparam>
public interface IWithSourceColorThemeBuilder<TBuilder>
    where TBuilder : IBuildableThemeBuilder
{
    /// <summary>
    /// Specify the source color that is used to build the <see cref="ThemeColors" />.
    /// </summary>
    /// <param name="color">The source color to use. In its HCT representation.</param>
    /// <returns>The <typeparamref name="TBuilder"/> with the specified platform.</returns>
    TBuilder WithSourceColor(HctColor color);

    /// <summary>
    /// Specify the source color that is used to build the <see cref="ThemeColors" />.
    /// </summary>
    /// <param name="color">The source color to use. In its RGB representation.</param>
    /// <returns>The <typeparamref name="TBuilder"/> with the specified platform.</returns>
    TBuilder WithSourceColor(RgbColor color);
    /// <summary>
    /// Specify the source color that is used to build the <see cref="ThemeColors" />.
    /// </summary>
    /// <param name="htmlColor">The source color to use. Either in the format <c>#FFFFFF</c> or <c>FFFFFF</c>.</param>
    /// <returns>The <typeparamref name="TBuilder"/> with the specified platform.</returns>
    TBuilder WithSourceColor(string htmlColor);
}
