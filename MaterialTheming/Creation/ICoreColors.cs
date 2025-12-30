using MaterialTheming.ColorDefinitions;

namespace MaterialTheming.Creation
{
    public interface ICoreColors
    {
        public RgbColor Primary { get; }
        public RgbColor Secondary { get; }
        public RgbColor Tertiary { get; }
        public RgbColor Error { get; }
        public RgbColor Neutral { get; }
        public RgbColor NeutralVariant { get; }
    }
}
