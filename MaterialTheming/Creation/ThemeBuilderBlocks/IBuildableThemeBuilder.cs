namespace MaterialTheming;

/// <summary>
/// EDefines a contract for theme builders that can build a <see cref="ThemeColors"/> object with the given input parameters.
/// </summary>
public interface IBuildableThemeBuilder
{
    /// <summary>
    /// Builds the <see cref="ThemeColors"/> with the specified parameters.
    /// </summary>
    /// <returns>The <see cref="ThemeColors"/> that matches in the specifed parameters.</returns>
    ThemeColors Build();
}
