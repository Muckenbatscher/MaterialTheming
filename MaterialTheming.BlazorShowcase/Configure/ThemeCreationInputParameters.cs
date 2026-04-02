using MaterialTheming;

namespace MaterialThemingShowcase.Configure;

public class ThemeCreationInputParameters
{
    public required RgbColor SourceColor { get; set; }
    public Variant Variant { get; set; }
    public ThemeMode Mode { get; set; }
    public ContrastLevel Contrast { get; set; }
    public SpecVersion SpecVersion { get; set; }
}
