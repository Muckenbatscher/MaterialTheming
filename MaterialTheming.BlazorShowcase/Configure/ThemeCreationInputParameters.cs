namespace MaterialTheming.BlazorShowcase.Configure;

public record ThemeCreationInputParameters
{
    public required RgbColor SourceColor { get; set; }
    public RgbColor? SecondSourceColor { get; set; }
    public Variant Variant { get; set; }
    public ThemeMode Mode { get; set; }
    public ContrastLevel Contrast { get; set; }
    public SpecVersion SpecVersion { get; set; }
    public Platform Platform { get; set; }
}
