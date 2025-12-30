using MaterialTheming.ColorDefinitions;
using MaterialTheming.Creation;

namespace MaterialTheming.MaterialDesign
{
    public class CoreColors : ICoreColors
    {
        public RgbColor Primary { get; set; }
        public RgbColor Secondary { get; set; }
        public RgbColor Tertiary { get; set; }
        public RgbColor Error { get; set; }
        public RgbColor Neutral { get; set; }
        public RgbColor NeutralVariant { get; set; }
    }
}
