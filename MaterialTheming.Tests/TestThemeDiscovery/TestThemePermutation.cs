namespace MaterialTheming.Tests.TestThemeDiscovery;

internal record TestThemePermutation(
    Variant Variant,
    Platform Platform,
    ThemeMode Mode,
    ContrastLevel ContrastLevel,
    SpecVersion SpecVersion);
