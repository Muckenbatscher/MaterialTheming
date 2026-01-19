namespace MaterialTheming.Creation.ThemeBuilderBlocks;

public interface IBuildableThemeBuilder
{
    /// <summary>
    /// Builds the <see cref="Theme"/> with the specified parameters.
    /// </summary>
    /// <returns>A <see cref="Theme"/> that matches in the specifed parameters.</returns>
    Theme Build();
}
