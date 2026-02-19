namespace MaterialTheming;

/// <summary>
/// Defines a contract for theme builders that support configuring a single source color or a pair of source colors
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

    /// <summary>
    /// Specify the second source color that is used to build the <see cref="ThemeColors" />.
    /// Currently only taken into account when building <see cref="Variant.CMF"/>.
    /// </summary>
    /// <param name="color">The source color to use. In its HCT representation.</param>
    /// <returns>The <typeparamref name="TBuilder"/> with the specified platform.</returns>
    TBuilder WithSecondSourceColor(HctColor color);
    /// <summary>
    /// Specify the second source color that is used to build the <see cref="ThemeColors" />.
    /// Currently only taken into account when building <see cref="Variant.CMF"/>.
    /// </summary>
    /// <param name="color">The source color to use. In its RGB representation.</param>
    /// <returns>The <typeparamref name="TBuilder"/> with the specified platform.</returns>
    TBuilder WithSecondSourceColor(RgbColor color);
    /// <summary>
    /// Specify the second source color that is used to build the <see cref="ThemeColors" />.
    /// Currently only taken into account when building <see cref="Variant.CMF"/>.
    /// </summary>
    /// <param name="htmlColor">The source color to use. Either in the format <c>#FFFFFF</c> or <c>FFFFFF</c>.</param>
    /// <returns>The <typeparamref name="TBuilder"/> with the specified platform.</returns>
    TBuilder WithSecondSourceColor(string htmlColor);

    /// <summary>
    /// Specify the two source colors that are used to build the <see cref="ThemeColors"/>. 
    /// Currently only taken into account when building <see cref="Variant.CMF"/>.
    /// </summary>
    /// <param name="firstSourceColor">The first source color to use. In its HCT representation.</param>
    /// <param name="secondSourceColor">The second source color to use. In its HCT representation.</param>
    /// <returns>The <typeparamref name="TBuilder"/> with the specified platform.</returns>
    TBuilder WithSourceColors(HctColor firstSourceColor, HctColor secondSourceColor);
    /// <summary>
    /// Specify the two source colors that are used to build the <see cref="ThemeColors"/>. 
    /// Currently only taken into account when building <see cref="Variant.CMF"/>.
    /// </summary>
    /// <param name="firstSourceColor">The first source color to use. In its RGB representation.</param>
    /// <param name="secondSourceColor">The second source color to use. In its RGB representation.</param>
    /// <returns>The <typeparamref name="TBuilder"/> with the specified platform.</returns>
    TBuilder WithSourceColors(RgbColor firstSourceColor, RgbColor secondSourceColor);
    /// <summary>
    /// Specify the two source colors that are used to build the <see cref="ThemeColors"/>. 
    /// Currently only taken into account when building <see cref="Variant.CMF"/>.
    /// </summary>
    /// <param name="firstSourceColorHtml">The first source color to use. Either in the format <c>#FFFFFF</c> or <c>FFFFFF</c>.</param>
    /// <param name="secondSourceColorHtml">The second source color to use. Either in the format <c>#FFFFFF</c> or <c>FFFFFF</c>.</param>
    /// <returns>The <typeparamref name="TBuilder"/> with the specified platform.</returns>
    TBuilder WithSourceColors(string firstSourceColorHtml, string secondSourceColorHtml);
}
