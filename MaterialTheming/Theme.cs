namespace MaterialTheming;

public class Theme
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Theme" /> class, that has the specifed dark mode and Material 3 color roles.
    /// </summary>
    /// <param name="isDark">Whether or not the <c>Theme</c> is a dark mode theme.</param>
    /// <param name="colors">The <c>ThemeColors</c> to be used for the Material 3 color roles in the theme.</param>
    public Theme(bool isDark, ThemeColors colors)
    {
        IsDark = isDark;
        Colors = colors;
    }
    /// <summary>
    /// Whether or not the <see cref="Theme" /> is a dark mode theme.
    /// </summary>
    public bool IsDark { get; }
    /// <summary>
    /// The <see cref="ThemeColors" /> of this <see cref="Theme" />. They provide access to the colors assigned to each of the Material 3 color roles.
    /// </summary>
    public ThemeColors Colors { get; } = new ThemeColors();
}
