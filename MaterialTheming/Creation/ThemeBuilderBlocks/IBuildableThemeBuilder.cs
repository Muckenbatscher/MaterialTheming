namespace MaterialTheming;

public interface IBuildableThemeBuilder
{
    /// <summary>
    /// Builds the <see cref="ThemeColors"/> with the specified parameters.
    /// </summary>
    /// <returns>The <see cref="ThemeColors"/> that matches in the specifed parameters.</returns>
    ThemeColors Build();
}
