using System.Drawing;

namespace MaterialTheming.Creation
{
    public interface ICoreColors
    {
        public Color Primary { get; }
        public Color Secondary { get; }
        public Color Tertiary { get; }
        public Color Error { get; }
        public Color Neutral { get; }
        public Color NeutralVariant { get; }
    }
}
