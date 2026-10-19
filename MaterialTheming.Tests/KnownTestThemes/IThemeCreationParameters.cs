namespace MaterialTheming.Tests.KnownTestThemes;

internal interface IThemeCreationParameters
{
    public string SourceColor { get; }
    public bool IsDark { get; }
    public double ContrastLevelValue { get; }
    public Platform Platform { get; }
    public Variant Variant { get; }
    public SpecVersion SpecVersion { get; }
}
