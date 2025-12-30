using MaterialTheming.ColorDefinitions;
using MaterialTheming.Creation;

namespace MaterialTheming.MaterialDesign
{
    public class CoreColors : ICoreColors
    {
        public RgbColor Primary { get; set; } = RgbColor.Empty;
        public RgbColor Secondary { get; set; } = RgbColor.Empty;
        public RgbColor Tertiary { get; set; } = RgbColor.Empty;
        public RgbColor Error { get; set; } = RgbColor.Empty;
        public RgbColor Neutral { get; set; } = RgbColor.Empty;
        public RgbColor NeutralVariant { get; set; } = RgbColor.Empty;
    }
}
