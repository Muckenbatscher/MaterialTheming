namespace MaterialTheming.Tests.TestThemeDiscovery;

internal record TestTheme(
    string Name,
    ThemeColors GeneratedThemeColors,
    ThemeColors ExpectedThemeColors);
